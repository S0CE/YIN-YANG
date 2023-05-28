/*
** EPITECH PROJECT, 2020
** 108trigo
** File description:
** main
*/

#include "trigo.h"
#include "error_message.h"

void free_struct(matrix_t *m)
{
    for (int i = 0; i != m->rows; i++) {
        free(m->matrix[i]);
        free(m->res_matrix[i]);
        free(m->id_matrix[i]);
        free(m->square_matrix[i]);
    }
    free(m);
}

int main(int ac, char **av)
{
    matrix_t *m = malloc(sizeof(matrix_t));

    if (ac == 2 && my_strcmp(av[1], "-h"))
        return (display_help());
    if (ac <= 2) {
        write_error(STR_ERROR_NBRARG);
        return (ERROR);
    }
    fill_matrices(m, ac, av);
    if (error_handling(ac, av, m)) {
        free_struct(m);
        return (ERROR);
    }
    trigo(m);
    free_struct(m);
    return (SUCCESS);
}
