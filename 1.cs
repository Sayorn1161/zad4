#include <iostream>
#include <string>

int main() {
    std::string number;
    int pos1, pos2;

    std::cout << "Введіть шестизначне число: ";
    std::cin >> number;

    if (number.length() != 6) {
        std::cout << "Помилка: число повинно бути шестизначним." << std::endl;
        return 1;
    }

    std::cout << "Введіть перший номер розряду для заміни (1-6): ";
    std::cin >> pos1;
    std::cout << "Введіть другий номер розряду для заміни (1-6): ";
    std::cin >> pos2;

    if (pos1 < 1 || pos1 > 6 || pos2 < 1 || pos2 > 6) {
        std::cout << "Помилка: номери розрядів повинні бути в діапазоні від 1 до 6." << std::endl;
        return 1;
    }

    // Заміна цифр
    std::swap(number[pos1 - 1], number[pos2 - 1]);

    std::cout << "Результат: " << number << std::endl;

    return 0;
}
