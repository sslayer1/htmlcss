#Let’s say I give you a list saved in a variable: 
# a = [1, 4, 9, 16, 25, 36, 49, 64, 81, 100]. 
# Write one line of Python that takes this list a 
# and makes a new list that has only the even elements of this list in it.

lista = [1, 4, 9, 16, 25, 36, 49, 64, 81, 100]
#listb = []

# for i in range (len(a)):
#     if a[i] % 2 == 0:
#         tempa = a[i]
#         b.append(tempa)
# print (b)     

listb = [i for i in lista if i % 2 == 0]

print (listb)