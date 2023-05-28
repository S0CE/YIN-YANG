/*
** EPITECH PROJECT, 2020
** 108trigo
** File description:
** trigo.h
*/

#ifndef __TRIGO_H__
#define __TRIGO_H__

#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <unistd.h>
#include <math.h>

typedef struct matrix_t
{
    double **matrix;
    double **res_matrix;
    double **id_matrix;
    double **square_matrix;
    int rows;
    int mode;
} matrix_t;

void trigo(matrix_t *m);
void compute_sinh(matrix_t *m);
void compute_cosh(matrix_t *m);

double calc_fact(double nb);
double compute_matrix(matrix_t *m, int i, int j);
double compute_matrix_bis(matrix_t *m, int i, int j);
void compute_square_matrix(matrix_t *m);
void divide_res_matrix(matrix_t *m, double stock, int u);

void fill_matrices(matrix_t *m, int ac, char **av);
void replenish_square_matrix(matrix_t *m);
void display_matrix(matrix_t *m);

int error_handling(int ac, char **av, matrix_t *m);
int my_strcmp(char const *str1, char const *str2);
void write_error(char *str);
int display_help(void);

#define SUCCESS 0
#define ERROR 84
#define TRUE 1
#define FALSE 0

#endif
