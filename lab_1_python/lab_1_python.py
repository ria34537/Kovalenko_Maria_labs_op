
#12. Задана довжина окола. Визначити площу кола обмеженого цим околом

import math
print("12. Задана довжина окола. Визначити площу кола обмеженого цим околом")
d = int(input("Введіть значення довжини кола ")) # вводимо значення довжини кола
s = (d*d)/(math.pi) # обчислюємо значення площі кола

print("Площа кола = ", round(s, 3)) # виводимо значення площі кола
