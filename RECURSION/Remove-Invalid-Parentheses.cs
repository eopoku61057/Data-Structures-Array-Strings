/*
    Remove the minimum number of invalid parentheses in order to make the input string valid. Return all possible results.
    Note: The input string may contain letters other than the parentheses ( and ).
    Time Complexity : O(2^N)
    Space Complexity : O(N)
 */


   private void recurse(string s, int index, int leftCount, int rightCount, StringBuilder expression, int removedCount)
        {
            // If we have reached the end of string
            if (index == s.Length)
            {
                // if the current expression is valid
                if(leftCount == rightCount)
                {
                    // if the current count of removed parentheses is <= the current minimum count
                    if (removedCount <= this.minimumRemoved)
                    {
                        // Convert StringBuilder to a String. This is an expensive operation.
                        // So we only perform this when needed.
                        string possibleAnswer = expression.ToString();

                        // If the current count beats the overall minimum we have till now
                        if (removedCount < this.minimumRemoved)
                        {
                            this.validExpressions.Clear();
                            this.minimumRemoved = removedCount;
                        }
                        this.validExpressions.Add(possibleAnswer);
                    }
                }
            }
            else
            {
                char currentCharacter = s[index];

                // If the current character is neither an opening bracket nor a closing one,
                // simply recurse further by adding it to the expression StringBuilder
                if (currentCharacter != '(' && currentCharacter != ')')
                {
                    expression.Append(currentCharacter);
                    this.recurse(s, index + 1, leftCount, rightCount, expression, removedCount); ;
                    expression.Remove(index, index + 1);
                }
                else
                {
                    // Recursion where we delete the current character and move forward
                    this.recurse(s, index + 1, leftCount, rightCount, expression, removedCount + 1);
                    expression.Append(currentCharacter);

                    // If it's an opening parenthesis, consider it and recurse
                    if (currentCharacter == '(')
                    {
                        this.recurse(s, index + 1, leftCount + 1, rightCount, expression, removedCount);
                    }
                    else if (rightCount < leftCount)
                    {
                        // For a closing parenthesis, only recurse if right < left
                        this.recurse(s, index + 1, leftCount, rightCount + 1, expression, removedCount);
                    }

                    expression.Remove(index, index + 1);
                }
            }
        }
        
