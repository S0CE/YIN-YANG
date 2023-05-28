/*
** EPITECH PROJECT, 2020
** 108trigo
** File description:
** trigo
*/

#include "trigo.h"

void compute_sin(matrix_t *m)
{
    double stock = 0;
    double stock1 = 0;

    for (int i = 0; i != m->rows; i++)
        for (int j = 0; j != m->rows; j++)
            m->id_matrix[i][j] = m->res_matrix[i][j];
    for (int k = 3, u = 0; k != 151; k += 2, u++) {
        for (int i = 0; i != m->rows; i++)
            for (int j = 0; j != m->rows; j++) {
                stock = calc_fact(k);
                m->res_matrix[i][j] = compute_matrix(m, i, j);
                stock1 = m->res_matrix[i][j] / stock;
                if ((u % 2) == 0)
                    m->id_matrix[i][j] -= stock1;
                else
                    m->id_matrix[i][j] += stock1;
            }
        replenish_square_matrix(m);
    }
    display_matrix(m);
}

void compute_cos(matrix_t *m)
{
    double stock = 0;
    double stock1 = 0;

    for (int k = 2, u = 0; k != 150; k = k + 2, u++) {
        stock = calc_fact(k);
        compute_square_matrix(m);
        divide_res_matrix(m, stock, u);
/*        for (int i = 0; i != m->rows; i++)
            for (int j = 0; j != m->rows; j++) {
                stock = calc_fact(k);
                m->res_matrix[i][j] = compute_matrix_bis(m, i, j);
                stock1 = m->res_matrix[i][j] / stock;
                if (u % 2 == 0)
                    m->id_matrix[i][j] -= stock1;
                else
                    m->id_matrix[i][j] += stock1;
            }
*/
        replenish_square_matrix(m);
    }
    display_matrix(m);
}

void compute_exp(matrix_t *m)
{
    double stock = 0;
    double stock1 = 0;

    for (int i = 0; i != m->rows; i++)
        for (int j = 0; j != m->rows; j++)
            m->id_matrix[i][j] += m->res_matrix[i][j];
    for (int k = 2; k != 150; k++) {
        for (int i = 0; i != m->rows; i++)
            for (int j = 0; j != m->rows; j++) {
                stock = calc_fact(k);
                m->res_matrix[i][j] = compute_matrix(m, i, j);
                stock1 = m->res_matrix[i][j] / stock;
                m->id_matrix[i][j] += stock1;
            }
        replenish_square_matrix(m);
    }
    display_matrix(m);
}

void trigo(matrix_t *m)
{
    switch (m->mode) {
    case 0 : compute_exp(m);
        break;
    case 1 : compute_cos(m);
        break;
    case 2 : compute_sin(m);
        break;
    case 3 : compute_cosh(m);
        break;
    case 4 : compute_sinh(m);
        break;
    }
}
