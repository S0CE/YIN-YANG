/*
** EPITECH PROJECT, 2020
** 108trigo
** File description:
** display the help
*/

#include "trigo.h"

int display_help(void)
{
    printf("USAGE\n    ./108trigo fun a0 a1 a2 ...\n\n");
    printf("DESCRIPTION\n    fun\t    function to be applied, among at least ");
    printf("“EXP“, “COS“, “SIN“, “COSH“ and “SINH“\n    ");
    printf("ai\t    coeficients of the matrix\n");
    return (SUCCESS);
}
