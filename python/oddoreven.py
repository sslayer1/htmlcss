
num = int(input("Please enter a whole number :>> "))
if num % 2 > 0:
    print ("The number " + str(num) + " you have entered is an odd number.")
else:
    print ("The number " + str(num) + " you have entered is an even number.")
    if num % 4 == 0:
        print ("The number " + str (num) + " is also a multiple of 4")

## Ask the user for two numbers: one number to check (call it num) 
## and one number to divide by (check). If check divides evenly into num, 
## tell that to the user. 
## If not, print a different appropriate message.        

num = int (input ("Please enter a number:>> "))
check = int (input ("Please enter a number to divide num by:>> "))

if num % check == 0:
    print(str(check) + " divides evenly into " + str(num))
else:
    print(str(check) + " does not divide evenly into " + str(num))
