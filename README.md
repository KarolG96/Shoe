Aplikacja WebAPI desktopowa do obsługi sklepu internetowego. 
Wymagania do uruchomienia: 
-VS 2022 .NET 6.0
-MS SQL Server ( w kodzie aplikacji wbudowany jest inicjalizator bazy danych )

Aby połączyć aplikację z bazą danych należy uaktualnić połączenie z SQL server w pliku appsettingjson, po ustanowieniu połączenia należy w Nuget Package Console wporwadzić komendę update-database. Aplikacja używa EntityFrameworkCore do obsługi baz danych.

W solution zawarte są cztery pod projekty które kounikują się ze sobą za pomocą API. Głównym projektem jest Shoe.Web, jest to projekt obsługujący aplikację desktopową. Zawiera on elementy frontend. Pozostałe pojekty to Service.ProductAPI, Service.ShoppingCartAPI oraz Service.Identity. Obsługują one poprzez połączenia przez API określone funkcjonalnośi aplikacji. 

Aplikacja obsługuje możliwośc rejstracji, składania zamówień, płatności oraz rewizji zamówień. 
Z poziomu administratora można dodawać, edytyować oraz usuwać produkty. Administartor ma także możliwość edycji zamówień.
