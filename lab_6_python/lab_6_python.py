        
        
        # 12 варіант  
import math

        #this function finds sin of exxponential function 
def SinExponent(num):
   result = math.sin(math.pow(math.e,(10 * num)))
   return result;
    
        #this will help us choose between two functions for inregral calculation
sin = SinExponent
atan = math.atan
 
        # this function finds intergral from a to b by dividing it to n parts 
def IntegralCalculation( num_a, num_b, num_n, function):
       
    h = ((num_b - num_a)) / (num_n)
    result = 0;

        #this part finds sum for integral
    sum_for_integral=0
    for i in range(1, num_n):
        sum_for_integral += function(num_a + i*h)

        #this finds int part  of calculating          
    int_part = int(((function(num_a) + function(num_b))/2 + sum_for_integral))

    result = int_part * h;
    return result;


#function for finding the sum of two integrals(one of them is squared)
def sum_of_integrals(a, b, n):
    answer =(math.pow(IntegralCalculation(a, b, n, atan),2) + IntegralCalculation(0, math.pi, n, sin));
    return answer;

#main function
print("please, input a ")
a = int(input())
print("please, input b ")
b = int(input())
print("please, input n, n>0 ")
n = int(input())

answer = sum_of_integrals(a, b, n)
print("answer is " + str(answer))

    


 
       
