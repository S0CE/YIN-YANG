/*
** EPITECH PROJECT, 2020
** 108trigo
** File description:
** div add and sub the matrices
*/

#include "trigo.h"

void divide_res_matrix(matrix_t *m, double stock, int u)
{
    double stock1 = 0;

    for (int i = 0; i != m->rows; i++)
        for (int j = 0; j != m->rows; j++) {
            stock1 = m->res_matrix[i][j] / stock;
            if (u % 2)
                m->id_matrix[i][j] += stock1;
            else
                m->id_matrix[i][j] -= stock1;
        }
}


