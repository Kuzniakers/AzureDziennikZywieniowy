Dokumentacja Projektu: Dziennik Żywieniowy


Opis Projektu
Dziennik Żywieniowy to aplikacja webowa, która pozwala użytkownikom na monitorowanie spożycia kalorii, zarządzanie swoimi posiłkami oraz śledzenie aktywności fizycznej. Projekt został stworzony z myślą o użytkownikach, którzy chcą lepiej kontrolować swoją dietę oraz zdrowie. Użytkownicy mogą dodawać nowe produkty, posiłki, a także śledzić deficyt kaloryczny na podstawie wprowadzonych danych o aktywności fizycznej.
Aplikacja została podzielona na dwie główne części:
1.	Frontend: Odpowiada za interfejs użytkownika, zapewniając przejrzystość i prostotę obsługi.
2.	Backend (API): Zajmuje się przetwarzaniem danych, komunikacją z bazą danych oraz obsługą logiki aplikacji.
Aplikacja została wdrożona w chmurze Microsoft Azure, co pozwala na skalowalność oraz łatwość utrzymania.
________________________________________
Funkcjonalności
1. Frontend
Frontend aplikacji został stworzony w technologii ASP.NET Core MVC. Główne funkcje obejmują:
•	Wyświetlanie tabel z danymi użytkownika, w tym listy produktów, posiłków oraz aktywności fizycznych.
•	Możliwość filtrowania danych w tabelach (np. filtrowanie po nazwie produktu lub dacie).
•	Formularze umożliwiające dodawanie nowych produktów, posiłków oraz aktywności.
2. Backend (API)
Backend aplikacji to RESTful API, zbudowane przy użyciu ASP.NET Core. Główne funkcje API:
•	Endpointy do odczytu, dodawania, edycji i usuwania danych (CRUD) dla:
o	Produktów spożywczych
o	Posiłków
o	Aktywności fizycznych
•	Obsługa zapytań GET, POST, PUT i DELETE.
•	Dokumentacja API dostępna w Swagger UI.
3. Baza danych
•	Baza danych aplikacji została wdrożona w Azure SQL Database.
•	Obsługuje tabele dla produktów, posiłków oraz aktywności fizycznych.
•	Dane są przechowywane w sposób bezpieczny i wydajny.
4. Deployment w Azure
•	Frontend i backend (API) zostały wdrożone jako kontenery Dockerowe w Azure App Service.
•	Azure Container Registry (ACR) służy jako rejestr obrazów Dockerowych.
•	Kontenery uruchamiane są w środowisku produkcyjnym w Azure.
5. Kluczowe funkcje aplikacji
•	Odczyt danych: Wyświetlanie danych w widokach tabelarycznych z możliwością filtrowania.
•	Zapis danych: Dodawanie nowych produktów, posiłków i aktywności fizycznych.
•	Swagger UI: Dokumentacja API umożliwiająca łatwe testowanie endpointów.
________________________________________
Technologie i Narzędzia
1. Technologie
•	ASP.NET Core MVC: Budowa frontendu i backendu.
•	Entity Framework Core: Obsługa bazy danych.
•	Docker: Konteneryzacja aplikacji.
•	Microsoft Azure: Chmura do hostowania aplikacji i bazy danych.
2. Narzędzia
•	Visual Studio 2022: IDE używane do tworzenia projektu.
•	Swagger UI: Generowanie i testowanie dokumentacji API.
•	Azure App Service: Hostowanie aplikacji w kontenerach.
•	Azure Container Registry (ACR): Przechowywanie obrazów Dockerowych.
________________________________________
Proces Tworzenia
1.	Planowanie: Wyznaczenie kluczowych funkcjonalności i zaprojektowanie architektury aplikacji.
2.	Budowa API:
o	Implementacja CRUD dla produktów, posiłków i aktywności.
o	Konfiguracja Swagger UI.
3.	Budowa Frontendu:
o	Tworzenie widoków tabelarycznych z możliwością filtrowania.
o	Formularze do dodawania danych.
4.	Integracja:
o	Połączenie frontendu z backendem za pomocą API.
o	Testowanie komunikacji między komponentami.
5.	Deployment:
o	Konteneryzacja aplikacji za pomocą Dockera.
o	Wdrożenie kontenerów do Azure App Service.
6.	Testowanie:
o	Testy jednostkowe i integracyjne.
o	Weryfikacja działania aplikacji w środowisku produkcyjnym.
________________________________________
Architektura Systemu
•	Frontend: Aplikacja MVC hostowana w Azure jako kontener.
•	Backend (API): RESTful API hostowane w Azure jako kontener.
•	Baza danych: Azure SQL Database, zintegrowana z backendem.
________________________________________
Podsumowanie
Projekt Dziennik Żywieniowy to kompleksowa aplikacja do zarządzania dietą i aktywnością fizyczną. Dzięki wykorzystaniu nowoczesnych technologii, takich jak ASP.NET Core, Docker i Microsoft Azure, aplikacja jest skalowalna, łatwa w utrzymaniu i dostarcza wartościowych funkcji użytkownikom. Wdrożenie w chmurze Azure zapewnia dostępność i niezawodność na wysokim poziomie. Dalsze rozwijanie projektu może obejmować funkcje takie jak autoryzacja użytkowników, zaawansowane raportowanie czy integracja z zewnętrznymi API fitness.
Linki:
Backend API na Azure: 
https://dziennikzywieniowybackendapi-fvf8bnepbfghabfk.polandcentral-01.azurewebsites.net/swagger/index.html

Aplikacja z poziomu Azure: 
https://dziennikzywieniowy-hhcng7h9g8f3gebq.polandcentral-01.azurewebsites.net/
Niepubliczny filmik Youtube:
https://www.youtube.com/watch?v=QfPLMRlSa6c&ab_channel=Coderad








