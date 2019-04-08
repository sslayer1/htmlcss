import datetime

##Create a program that asks the user to enter their name 
##and their age. Print out a message addressed to them that 
##tells them the year that they will turn 100 years old.
yourname = input("Please enter your name:>> ")
yourage = int(input("Please enter your age this year:>>"))

now = datetime.datetime.now()
noOfYearsIn100 = 100 - yourage
turn100InYear = now.year + noOfYearsIn100


#print (yourname)
#print (yourage)
#print (noOfYearsIn100)
#print (yourname + " you will be 100 in the year " + str(turn100InYear))

numberOfLines = int(input("Please enter a number:>> "))
for i in range (numberOfLines):
    print (str(i) + "." + yourname + " you will be 100 in the year " + str(turn100InYear))


## Run in terminal window using ./<filename including extension>


