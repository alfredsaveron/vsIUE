#include <stdio.h>

int main() {
    char c;
    printf("Enter a character: ");
    c = getchar(); // Single character from the user
    printf("You just entered: %c\n", c);
    return 0;
}
