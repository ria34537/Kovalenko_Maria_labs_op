#12. Дано натуральне число n. Визначити всі числа, менші за n, та взаємно прості з ним.


def FindingMinDiv( num_1, num_2):
    while num_1 != num_2:
        if (num_1 > num_2):
            num_1 = num_1 - num_2
        else:
            num_2 = num_2 - num_1
    result = num_1
    return result;
#функція для пошуку найбільшого спільного дільника       


def AllSimpleNumbers(num):
    for i in range(1, int(num)):
           if FindingMinDiv(i, num)==1:
               print(i)
#функція для виведення всіх взаємно простих чисел


print("Please, input n: ")
n = int(input())
AllSimpleNumbers(n)
