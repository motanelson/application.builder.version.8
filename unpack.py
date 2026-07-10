import os
import copy
print("\033c\033[47;30m\ngive me the .bjava pack file ? \n")
a=input().strip()
f1=open(a,"rb")
f=f1.read()
f1.close()
ff=f.split(b"\x01\x00\x05\x04\x03\x02")

if ff[0]!=b"JAVA":
    printf("this is not a pack file to 1 file")
    exit(1)

counter=0
for d in ff:
    if d.strip()!=b"":
        print(d.decode())
        
    counter=counter+1

counter=0