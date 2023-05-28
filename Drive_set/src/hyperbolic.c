/*
** EPITECH PROJECT, 2020
** 108trigo
** File description:
** cosh and sinh
*/

#include "trigo.h"

void compute_sinh(matrix_t *m)
{
    double stock = 0;
    double stock1 = 0;

    for (int i = 0; i != m->rows; i++)
        for (int j = 0; j != m->rows; j++)
            m->id_matrix[i][j] = m->res_matrix[i][j];
    for (int k = 3; k != 151; k = k + 2) {
        for (int i = 0; i != m->rows; i++)
            for (int j = 0; j != m->rows; j++) {
                stock = calc_fact(k);
                m->res_matrix[i][j] = compute_matrix_bis(m, i, j);
                stock1 = m->res_matrix[i][j] / stock;
                m->id_matrix[i][j] += stock1;
            }
        replenish_square_matrix(m);
    }
    display_matrix(m);
}

void compute_cosh(matrix_t *m)
{
    double stock = 0;
    double stock1 = 0;

    for (int k = 2; k != 150; k = k + 2) {
        for (int i = 0; i != m->rows; i++)
            for (int j = 0; j != m->rows; j++) {
                stock = calc_fact(k);
                m->res_matrix[i][j] = compute_matrix_bis(m, i, j);
                stock1 = m->res_matrix[i][j] / stock;
                m->id_matrix[i][j] += stock1;
            }
        replenish_square_matrix(m);
    }
    display_matrix(m);
}
