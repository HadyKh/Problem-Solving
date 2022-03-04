import re

a = input()
b = input()

b = re.compile(b)

m = b.search(a)

if not m:
    print('(-1, -1)')

while m:
    print(f'({m.start()}, {m.end() - 1})')
    m = b.search(a, m.start() + 1)
