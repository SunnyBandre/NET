import numpy as n
r = int(input("Enter Number of Rows: "))
c = int(input("Enter Number of Columns: "))
k = int(input("Enter Scalar: "))
M =[]
print("Enter Elements: ")
for i in range (r):
    a = []
    for j in range (c):
        a.append(int(input()))
    M.append(a)
print("\n")
print("Matrix ")
for i in range(r):
    for j in range (c):
        print (M[i][j], end=" ")
    print()

print("\n") 
print("Scalar Multiplication of the Matrix ")
for i in range (r):
	for j in range (c):
		print(k*M[i][j], end=" ")
	print()
	
print("\n")    
print("Transpose of the Matrix ")
for i in range (r):
	for j in range (c):
		print(M[j][i], end=" ")
	print()

print("\n")
print("Rows")
for i in range(r):
    print("Rows ",i+1," is: ")
    print(M[i])

print("\n")
print("Columns")
for i in range(c):
    a=[]
    for j in range (r):
        a.append(M[j][i])
    print("Columns ",j+1," is: ")
    print(a)
