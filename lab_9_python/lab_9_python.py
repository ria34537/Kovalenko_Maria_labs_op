
def delete_words(frase, symb):
    size_of_symb = len(symb)
    words = frase.split()
    number_deleted = 0

    for i in range(0,len(words)):
      for word in words:        
        end_of_word = str(word[len(word) - size_of_symb::])
        if symb == end_of_word:
            words.remove(word)
            number_deleted+=1
    new_string = ' '.join(words)
    return new_string, number_deleted


frase = input("frase: ")
symbols = input("symbols: ")
frase, number_deleted = delete_words(frase, symbols)
print("frase: ", frase)
print("num_of_deletions: ", number_deleted)