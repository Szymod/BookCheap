# BookCheap
Repozytorium założone na potrzeby projektu zespołowego 2015/2016 r. Projekt dotyczy zarządzania hotelami i rezerwacjami pokoi.

Uruchomienie:

Zainstalować mssql server. Jesli logowanie domenowe uzytkownik potrzebuje uprawnien do tworzenia nowej bazy danych. Jesli uzytkownik
bazodanowy to trzeba mu nadac te same uprawnienia i dodatkowo zmienic connection-string pliku web.config clienta webowego, web.config
webservisu i app.config projektu testowego.

#Klika zasad które pomoga w utrzymaniu porzadku
Wszystkie zmienne, metody klasy itd.. nazywamy wedlug konwencji przyjetej przez microsoft dla jezyka C#
  Najwazniejsze:
    ● nazwy klas i metod zaczynają się z dużej litery, poszczegolne czlony tez (CamelCase) np. GameTable
    ● nazwy zmiennych i pól zaczynają się z małej litery (np. currentPosition)
    ● nazwy zmiennych i pól prywatnych zaczynają się od podkreslenia (np. _currentPosition)
    ● nazwy metod, właściwości, zdarzeń (ang. events) zaczynają się z dużej litery (np. MovePawn,
    Position, Moved)
    ● wszystkie nazwy w języku angielskim
