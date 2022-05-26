def average(salary) -> float:
        salary.sort()
        s = float(sum(salary[1 : -1]) / (len(salary) - 2))
        s = round(s, 5)
        print(s)

numbers = input('Enter a bunch of numbers separated by a space:')
num_list = [int(i) for i in numbers.split()]
average(num_list)
