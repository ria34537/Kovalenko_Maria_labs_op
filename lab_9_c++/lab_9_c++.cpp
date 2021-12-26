// lab_9_c++.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.

#include <iostream>
#include <string>

using namespace std;

//this function deletes words which have group of inputed symbols at the end
string delete_words(string str, string symb) {
    string result = "";
    string word = "";
    int count_for_match = 0;
    int index = 0;

    for (int k = 0; k < str.size(); ) {

        //finding one word
        while (str[k] != ' ' && k < str.size()) {

            word = word + str[k];
            k++;
        }

        k++;

        //when word has not out group in the end adding it to answer
        for (int i = 0; i < symb.size(); i++)
        {
            index = word.length() - symb.size() + i;
            if (word[index] == symb[i]) {
                count_for_match++;
            }
        }
        if (count_for_match != symb.size()) {
            result += word + " ";
        }

        count_for_match = 0;
        word = "";
    }

    return result;
}
int count_of_deleted(string str, string symb) {
    int result = 0;
    string word = "";
    int count_for_match = 0;
    int index = 0;

    for (int k = 0; k < str.size(); ) {

        //finding one word
        while (str[k] != ' ' && k < str.size()) {

            word = word + str[k];
            k++;
        }

        k++;
                
        for (int i = 0; i < symb.size(); i++)
        {
            index = word.length() - symb.size() + i;
            if (word[index] == symb[i]) {
                count_for_match++;
            }
        }
        if (count_for_match != symb.size()) {
            result++;
        }

        count_for_match = 0;
        word = "";
    }

    return result;
}



void main() {
    string str = "";
    getline(cin, str);

    string symb = "";
    getline(cin, symb);

    str = delete_words(str, symb);
    cout << "new line: " << str << endl;

    int count = count_of_deleted(str, symb);
    cout << "count of deleted words: " << count;

}