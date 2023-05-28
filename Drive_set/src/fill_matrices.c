/*
** EPITECH PROJECT, 2020
** 108trigo
** File description:
** fill the matrices
*/

#include "trigo.h"

void replenish_square_matrix(matrix_t *m)
{
    for (int i = 0; i != m->rows; i++)
        for (int j = 0; j != m->rows; j++)
            m->square_matrix[i][j] = m->res_matrix[i][j];
}

void display_matrix(matrix_t *m)
{
    for (int i = 0; i != m->rows; i++)
        for (int j = 0; j != m->rows; j++) {
            if (j == m->rows - 1)
                printf("%.2f\n", m->id_matrix[i][j]);
            else
                printf("%.2f\t", m->id_matrix[i][j]);
        }
}

void fill_id_matrix(matrix_t *m)
{
    m->id_matrix = malloc(sizeof(double *) * m->rows);
    for (int i = 0; i != m->rows; i++) {
        m->id_matrix[i] = malloc(sizeof(double) * m->rows);
        for (int j = 0; j != m->rows; j++)
            m->id_matrix[i][j] = 0;
    }
    for (int i = 0, j = 0; i != m->rows; i++, j++)
        m->id_matrix[i][j] = 1;
}

void fill_square_matrix(matrix_t *m)
{
    m->square_matrix = malloc(sizeof(double *) * m->rows);
    for (int i = 0; i != m->rows; i++) {
        m->square_matrix[i] = malloc(sizeof(double) * m->rows);
        for (int j = 0; j != m->rows; j++)
            m->square_matrix[i][j] = m->matrix[i][j];
    }
}

void fill_matrices(matrix_t *m, int ac, char **av)
{
    int k = 2;

    m->rows = ceil(sqrt(ac-2));
    m->matrix = malloc(sizeof(double *) * m->rows);
    m->res_matrix = malloc(sizeof(double *) * m->rows);
    fill_id_matrix(m);
    for (int i = 0; i != m->rows; i++) {
        m->matrix[i] = malloc(sizeof(double) * m->rows);
        m->res_matrix[i] = malloc(sizeof(double) * m->rows);
        for (int j = 0; j != m->rows; j++, k++) {
            if (k == ac) {
                m->matrix[i][j] = (double) 0;
                m->res_matrix[i][j] = (double) 0;
            }
            else {
                m->matrix[i][j] = atoi(av[k]);
                m->res_matrix[i][j] = atoi(av[k]);
            }
        }
    }
    fill_square_matrix(m);
}
