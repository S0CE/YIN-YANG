/*
** EPITECH PROJECT, 2020
** navy
** File description:
** write on the error output
*/

#include "trigo.h"
#include "error_message.h"

void write_error(char *str)
{
    write(2, str, strlen(str));
    write(2, STR_HELP, strlen(STR_HELP));
}
