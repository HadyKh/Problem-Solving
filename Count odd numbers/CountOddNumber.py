counter = 0
low = int(input())
high = int(input())
# for i in range(low, high + 1):
#     if(i % 2 != 0):
#         counter += 1
#counter = range(low - 1, high + 1)[low%2::2]
#print(len(list(range(l if l % 2 else l + 1, r + 1, 2))))
if low % 2 != 0 or high % 2 != 0:
    print(((high - low) // 2) +1)
else:
    print((high - low) // 2)



#print((high - low) // 2 + 1 if low % 2 or high % 2 else (high - low) // 2)
