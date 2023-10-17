# Setting Up Standard Input and Output in C

In C programming, standard input (often referred to as `stdin`) is used for reading input, while standard output (`stdout`) is used for displaying output. These input and output operations are typically performed using functions provided by the `stdio.h` library. Here's how you can set up and use standard input and output in C.

## Standard Input (stdin)

Standard input is used for reading input, such as user input or data from files. You can use the `scanf` function for formatted input or `getchar` for character input.

### Formatted Input with `scanf`

```c
#include <stdio.h>

int main() {
    int num;
    printf("Enter an Integer: ");
    scanf("%d", &num); // Integer from the user
    printf("You entered: %d\n", num);
    return 0;
}
```

### Character Input with `getchar`

```c
#include <stdio.h>

int main() {
    char c;
    printf("Enter a character: ");
    c = getchar(); // Single character from the user
    printf("You just entered: %c\n", c);
    return 0;
}
```

## Standard Output (stdout)

Standard output is used for displaying output, such as messages, results, or data. The `printf` function is commonly used for formatted output.

### Formatted Output with `printf`

```c
#include <stdio.h>

int main() {
    int num = 42;
    printf("Answer is: %d\n", num); // Formatted message
    return 0;
}
```
