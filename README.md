# Baza Kontaktów

Baza Kontaktów to prosta aplikacja do zarządzania kontaktami, napisana w C#. Pozwala użytkownikom na dodawanie, edytowanie, usuwanie i wyszukiwanie kontaktów, a także sortowanie ich według imienia, nazwiska lub daty.

## Funkcje

- Dodawanie nowych kontaktów z imieniem, nazwiskiem, numerem telefonu i datą.
- Edytowanie istniejących kontaktów.
- Usuwanie pojedycznego kontaktu lub wszystkich zapisanych.
- Sortowanie kontaktów według imienia, nazwiska lub daty.
- Wyszukiwanie kontaktów według imienia i nazwiska.
- Zapisywanie kontaktów do pliku i ładowanie ich podczas uruchamiania.

## Instalacja

1. Sklonuj repozytorium:
 ```

 git clone https://github.com/jakubir/baza_kontaktow.git

 ```
   
2. Otwórz plik wykonywalny z:
```

Baza_kontaktow/bin/publish

```

## Użytkowanie

### Uruchom aplikację:
- Uruchom zbudowaną aplikację z określonej ścieżki.

### Dodaj kontakt:
- Kliknij przycisk "Kontakty".
- Kliknij przycisk "Dodaj kontakt".
- Wypełnij dane kontaktowe (Imię, Nazwisko, Telefon (w polskim formacie), Data).
- Kliknij "Dodaj", aby zapisać nowy kontakt.
- Gdy kontakt o identycznych danych już istenieje, aplikacja automatycznie usunie ten duplikat.

### Edytuj kontakt:
- Wybierz kontakt z listy.
- Kliknij przycisk "Kontakty".
- Kliknij przycisk "Edytuj kontakt".
- Zmodyfikuj dane kontaktowe.
- Kliknij "Zatwierdź zmiany", aby zapisać modyfikacje.
- Gdy kontakt o identycznych danych już istenieje, aplikacja automatycznie usunie ten duplikat.

### Usuń kontakt:
- Wybierz kontakt z listy.
- Kliknij przycisk "Kontakty".
- Kliknij przycisk "Usuń kontakt".
- Potwierdź usunięcie kontaktu w oknie komunikatu za pomocą przycisku "OK".

### Wyszukaj kontakt:
- Kliknij przycisk "Opcje".
- Kliknij przycisk "Wyszukaj".
- Wprowadź frazę wyszukiwania i naciśnij "Szukaj".
- Gdy zostanie odnaleziony pasujący kontakt, aplikacja wyświetli go.
- Gdy nie zostanie odnaleziony żaden pasujący kontakt, aplikacja wyświetli kontakt ostatnio wybrany lub pierwszy z listy kontaktów.

### Sortuj kontakty:
- Kliknij przycisk "Sortowanie".
- Kliknij na opcje sortowania (Imię, Nazwisko, Data), aby posortować kontakty odpowiednio.

### Zapisz zmiany
- Kliknij przycisk "Kontakty".
- Kliknij przycisk "Zapisz", aby zapisać obecną wersję bazy kontaktów.

### Wyczyść dane
- Kliknij przycisk "Kontakty".
- Kliknij przycisk "Nowa baza kontaktów".
- Potwierdź wyczyszczenie bazy kontaktów w oknie komunikatu za pomocą przycisku "OK".

### Zamknięcie aplikacji
- Kliknij przycisk "Kontakty".
- Kliknij przycisk "Koniec", aby zakończyć działanie aplikacji.
