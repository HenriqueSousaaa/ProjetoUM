#include <stdio.h>
#include <math.h>

#define PI 3.14159

int main() {
    float raio, altura, volume;

    printf("Insira o raio da bobina (em metros): ");
    scanf("%f", &raio);

    printf("Insira a altura da bobina (em metros): ");
    scanf("%f", &altura);

    volume = PI * pow(raio, 2) * altura;

    printf("O volume da bobina fundo tecnológico é: %.2f metros cúbicos\n", volume);

    return 0;
}
