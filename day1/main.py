input_file = open('input.txt','r')
input_lines = input_file.readlines()

highest_number = 0
highest_numbers = []
current_count = 0

for line in input_lines:
    if line != "\n":
        current_count += int(line)
        print(current_count)
        if (current_count > highest_number):
            print("HIGHER")
            highest_number = current_count
            
    else:
        highest_numbers.append(current_count)
        current_count = 0
highest_numbers.sort(reverse=True)
print(highest_number)
print(highest_numbers[0] + highest_numbers[1] + highest_numbers[2])