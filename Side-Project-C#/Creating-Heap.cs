using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    public class MinIntHeap
    {
        private int capacity = 10;
        private int size = 0;

        private int[] items = new int[10];

        private int getLeftChildIndex (int parentIndex)
        {
            return 2 * parentIndex + 1;
        }

        private int getRightChildIndex (int parentIndex)
        {
            return 2 * parentIndex + 2;
        }

        private int getParentIndex(int childIndex)
        {
            return (childIndex - 1) / 2;
        }

        private Boolean hasLeftChild(int index)
        {
            return getLeftChildIndex(index) < size;
        }

        private Boolean hasRightChild(int index)
        {
            return getRightChildIndex(index) < size;
        }

        private Boolean hasParent(int index)
        {
            return getParentIndex(index) >= 0;
        }

        private int leftChild(int index)
        {
            return items[getLeftChildIndex(index)];
        }

        private int rightChild(int index)
        {
            return items[getRightChildIndex(index)];
        }

        private int parent(int index)
        {
            return items[getParentIndex(index)];
        }

        private void Swap(int indexOne, int indexTwo)
        {
            int tmp = items[indexOne];
            items[indexOne] = items[indexTwo];
            items[indexTwo] = tmp;
        }

        private void EnsureExtraCapacity()
        {
            if (size == capacity)
            {
                Array.Copy(items, items, capacity * 2);
                capacity *= 2;
            }
        }

        public int peek()
        {
            if (size == 0) return -1;
            return items[0];
        }

        public int poll()
        {
            if (size == 0) return -1;
            int item = items[0];
            items[0] = items[size - 1];
            size--;
            HeapifyDown();
            return item;
        }

        public void Add(int item)
        {
            EnsureExtraCapacity();
            items[size] = item;
            size++;
            HeapifyUp();
        }

        private void HeapifyUp()
        {
            int index = size - 1;
            while (hasParent(index) && parent(index) > items[index])
            {
                Swap(getParentIndex(index), index);
                index = getParentIndex(index);
            }
        }
        private void HeapifyDown()
        {
            int index = 0;
            while (hasLeftChild(index))
            {
                int smallestChildIndex = getLeftChildIndex(index);
                if (hasRightChild(index) && rightChild(index) < leftChild(index))
                {
                    smallestChildIndex = getRightChildIndex(index);
                }

                if(items[index] < items[smallestChildIndex])
                {
                    break;
                }
                else
                {
                    Swap(index, smallestChildIndex);
                }
                index = smallestChildIndex;
            }
        }
    }
}
