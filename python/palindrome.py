# Ask the user for a string and print out whether this string
# is a palindrome or not. (A palindrome is a string that reads 
# the same forwards and backwards.)

forward = []
backward = []

inputIsPalindrome = 'Y'

inputString = input("Please enter a string:>> ")

for i in range(0, len(inputString)):
    tempa = inputString[i]
    forward.append (tempa)
print(forward)    

for j in range(len(forward) - 1, -1, -1):
    tempb = forward[j]
    backward.append(tempb)
print(backward)

for k in range(len(forward)):
    elementforward = forward[k]
    for m in range (len(backward)-1, -1, -1):
        elementbackward = backward[k]
        if elementforward != elementbackward:
            inputIsPalindrome = 'N'

if inputIsPalindrome == 'Y':
    print("The input is a palindrome.")
else:
    print("The input is not a palindrome.")