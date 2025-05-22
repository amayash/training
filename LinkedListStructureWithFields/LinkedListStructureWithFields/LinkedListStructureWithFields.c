#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <stdbool.h>
#pragma execution_character_set("utf-8")

// создать структуру с полями
// создать список со структурами
// функции: добавление в список, вывод списка
// список должен быть двусвязным с сортировкой (на 5), односвязным (на 4), коллекции (на 3)

typedef struct Student {
    char name[50];
    int age;
    float gpa;
} Student;

typedef struct Node {
    Student data;
    struct Node* prev;
    struct Node* next;
} Node;

Node* create_node(Student s) {
    Node* new_node = (Node*)malloc(sizeof(Node));
    new_node->data = s;
    new_node->prev = NULL;
    new_node->next = NULL;
    return new_node;
}

void insert_sorted(Node** head, Student s) {
    Node* new_node = create_node(s);

    if (*head == NULL) {
        *head = new_node;
        return;
    }

    Node* current = *head;
    while (current != NULL && current->data.age < s.age) {
        current = current->next;
    }

    if (current == NULL) {
        // Вставка в конец
        Node* last = *head;
        while (last->next != NULL) last = last->next;
        last->next = new_node;
        new_node->prev = last;
    }
    else if (current == *head) {
        // Вставка в начало
        new_node->next = *head;
        (*head)->prev = new_node;
        *head = new_node;
    }
    else {
        // Вставка перед current
        Node* prev = current->prev;
        prev->next = new_node;
        new_node->prev = prev;
        new_node->next = current;
        current->prev = new_node;
    }
}

void print_list(Node* head) {
    Node* current = head;
    while (current != NULL) {
        printf("Имя: %s, Возраст: %d, Средний балл: %.2f\n", current->data.name, current->data.age, current->data.gpa);
        current = current->next;
    }
}

int main() {
    SetConsoleOutputCP(65001);
    Node* list = NULL;

    Student s1 = { "Иванов", 20, 4.2 };
    Student s2 = { "Петров", 18, 4.8 };
    Student s3 = { "Сидоров", 22, 3.9 };
    Student s4 = { "Алексеев", 19, 4.5 };

    insert_sorted(&list, s1);
    insert_sorted(&list, s2);
    insert_sorted(&list, s3);
    insert_sorted(&list, s4);

    printf("Список студентов:\n");
    print_list(list);

    return 0;
}
