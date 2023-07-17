## Sklep internetowy - README

Witamy w aplikacji WebAPI desktopowej do obsługi sklepu internetowego! Aplikacja umożliwia zarządzanie sklepem internetowym, obsługę zamówień, płatności oraz rejestrację użytkowników. Poniżej przedstawiamy informacje dotyczące uruchamiania, konfiguracji i dokumentacji aplikacji.

### Wymagania systemowe

Aby uruchomić aplikację, musisz spełnić następujące wymagania:

- Visual Studio 2022 z wersją .NET 6.0
- MS SQL Server (w kodzie aplikacji znajduje się inicjalizator bazy danych)

### Instalacja i konfiguracja

1. Otwórz projekt w Visual Studio 2022.
2. Skonfiguruj połączenie z bazą danych SQL Server w pliku `appsettings.json`.
3. Po ustanowieniu połączenia z bazą danych, uruchom konsolę NuGet Package Manager i wprowadź komendę `update-database`. To spowoduje migrację i utworzenie niezbędnych tabel w bazie danych.
4. Uruchom aplikację.

### Struktura projektu

W rozwiązaniu (solution) znajdują się cztery projekty, które komunikują się ze sobą za pomocą interfejsu API. Główny projekt to `Shoe.Web`, który obsługuje aplikację desktopową i zawiera elementy frontendowe. Pozostałe projekty to `Service.ProductAPI`, `Service.ShoppingCartAPI` oraz `Service.Identity`. Odpowiadają one za funkcjonalności aplikacji i komunikację poprzez interfejsy API.

### Używanie Mappera

Aplikacja wykorzystuje Mappera do mapowania obiektów między warstwami. Mapper umożliwia przekształcenie danych między modelami domenowymi a modelami DTO (Data Transfer Object), co ułatwia komunikację między frontendem a backendem. Mapper jest skonfigurowany w projekcie `Shoe.Web` i jest używany do konwersji obiektów w celu obsługi żądań API.

### Funkcje aplikacji

Aplikacja obsługuje następujące funkcje:

- Rejestracja użytkowników: Aby założyć nowe konto, użyj formularza rejestracji dostępnego pod przestrzenią logowania.
- Zarządzanie bazą produktów poprzez API: Administrator może dodawać, usuwać i edytować produkty w sklepie. Produkty są dostępne za pomocą dwóch metod GET. Możliwe jest także dodawanie nowych produktów za pomocą metody POST, edycja produktów za pomocą metody PUT oraz usuwanie produktów za pomocą metody DELETE.
- Obsługa koszyka: Zalogowani użytkownicy mogą dodawać, usuwać i edytować zamówienia w koszyku. Metoda GET jest używana do pobierania zawartości koszyka, a metody POST są wykorzystywane do dodawania nowych pozycji do koszyka.

### Dokumentacja API

Będzie dodana

### Autorzy

- Karol Gajda 
- Jakub Gajda 
