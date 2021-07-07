######################################
####### 카카오톡 코딩테스트 #############
######################################

## 십진수값을 이진수값으로 치환, 이진수 값 리스트를 문자열화
print("함수 테스트입니다.")
def binary(num):
    lst = []

    while num != 0:
        lst.append(num % 2)
        num //= 2
        # print(lst, num)

    if num == 1:
        lst.append(1)

    lst.reverse()

    ## 이진수값을 문자열화
    for i in range(len(lst)):
        result_str = "".join(str(a)for a in lst)

    return result_str


print("function> binary의 결과입니다. (29) -> " + binary(29))


# 변의 길이(len)에 맞게끔 0을 추가
def len_5(len_amount, index_str):
    if len(index_str) < len_amount:
        while len(index_str) < len_amount:
            index_str = "0" + index_str

    return index_str

print("function> len_5의 결과입니다. (\"1001\") -> " + len_5(5, "1001"))


# 1을 #으로, 0을 공백으로 치환
def swap(index_str):
    return_str = ""

    for index in range(len(index_str)):
        if index_str[index] == "1":
            return_str += "#"
        else:
            return_str += "_"

    return return_str

print("function> swap의 결과입니다. (\"10011\") -> " + swap("10011"))


# "#" OR " " 합치기
def task(char_1, char_2):
    result_str = ""

    for char_index in range(len(char_1)):
        if char_1[char_index] == "#" and char_1[char_index] == char_2[char_index]:
            result_str += "#"
        elif char_1[char_index] == "#" and char_1[char_index] != char_2[char_index]:
            result_str += "#"
        elif char_1[char_index] == "_" and char_1[char_index] != char_2[char_index]:
            result_str += "#"
        else:
            result_str += "_"

    return result_str

# print(task("###  ###  ", "##  ### # "))

print("function> task의 결과입니다. (\"#__#_\", \"##__#\") -> " + task("#__#_", "##__#") + "\n\n")






#############################################################################
############################# main ##########################################
#############################################################################

def input_value(n, list_1, list_2):
    output_1 = []
    output_2 = []
    result = []

    for i in range(n):
        output_1.append(binary(list_1[i]))
        output_2.append(binary(list_2[i]))

    # print(output_1, output_2)

# input_value(5, [9, 20, 28, 18, 11], [30, 1, 21, 17, 28])

    for make_len in range(n):
        output_1[make_len] = len_5(n, output_1[make_len])
        output_2[make_len] = len_5(n, output_2[make_len])

    # print(output_1, output_2)

# input_value(5, [9, 20, 28, 18, 11], [30, 1, 21, 17, 28])

    for index in range(n):
        output_1[index] = swap(output_1[index])
        output_2[index] = swap(output_2[index])

    # print(output_1, output_2)

# input_value(5, [9, 20, 28, 18, 11], [30, 1, 21, 17, 28])

    for index in range(n):
        result.append(task(output_1[index], output_2[index]))

    return result

print(input_value(5, [9, 20, 28, 18, 11], [30, 1, 21, 17, 28]))
print(input_value(6, [46, 33, 33, 22, 31, 50], [27, 56, 19, 14, 14, 10]))



