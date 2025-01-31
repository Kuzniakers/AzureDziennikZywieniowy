# Dziennik Żywieniowy

## Przygotował
- Konrad Kuźniak

## Opis Projektu
Dziennik Żywieniowy to aplikacja webowa, która pozwala użytkownikom monitorować spożycie kalorii, zarządzać swoimi posiłkami oraz śledzić aktywność fizyczną. Projekt został stworzony z myślą o użytkownikach, którzy chcą lepiej kontrolować swoją dietę i zdrowie. Użytkownicy mogą dodawać nowe produkty, posiłki, a także śledzić deficyt kaloryczny na podstawie danych o aktywności fizycznej.

Aplikacja została podzielona na dwie główne części:
1. **Frontend** – interfejs użytkownika, zapewniający przejrzystość i prostotę obsługi.
2. **Backend (API)** – przetwarzanie danych, komunikacja z bazą oraz logika aplikacji.

Aplikacja została wdrożona w chmurze Microsoft Azure dla lepszej skalowalności i łatwości utrzymania.

---

## Funkcjonalności

### 1. Frontend
Frontend aplikacji zbudowano w technologii ASP.NET Core MVC. Główne funkcje:
- Wyświetlanie tabel z danymi użytkownika (produkty, posiłki, aktywności).
- Możliwość filtrowania danych w tabelach (np. po nazwie produktu, dacie).
- Formularze do dodawania nowych produktów, posiłków oraz aktywności.

### 2. Backend (API)
Backend to RESTful API, zbudowane przy użyciu ASP.NET Core. Główne funkcje:
- Endpointy CRUD (odczyt, dodawanie, edycja, usuwanie) dla produktów, posiłków oraz aktywności.
- Obsługa zapytań GET, POST, PUT i DELETE.
- Dokumentacja API dostępna w **Swagger UI**.

### 3. Baza danych
- Baza danych w Azure SQL Database.
- Przechowywanie danych o produktach, posiłkach i aktywnościach w sposób bezpieczny i wydajny.

### 4. Deployment w Azure
- Aplikacja wdrożona jako kontenery Dockerowe w Azure App Service.
- **Azure Container Registry (ACR)** przechowuje obrazy Dockerowe.

### 5. Kluczowe funkcje
- Wyświetlanie danych z możliwością filtrowania.
- Dodawanie nowych produktów, posiłków i aktywności.
- Dokumentacja API w **Swagger UI**.

---

## Technologie i Narzędzia

### Technologie
- **ASP.NET Core MVC** – frontend i backend.
- **Entity Framework Core** – obsługa bazy danych.
- **Docker** – konteneryzacja aplikacji.
- **Microsoft Azure** – chmura do hostowania aplikacji.

### Narzędzia
- **Visual Studio 2022** – IDE używane do tworzenia projektu.
- **Swagger UI** – testowanie API.
- **Azure App Service** – hostowanie kontenerów.
- **Azure Container Registry (ACR)** – rejestr obrazów Dockerowych.

---

## Proces Tworzenia
1. **Planowanie** – określenie funkcjonalności i zaprojektowanie architektury.
2. **Budowa API** – implementacja CRUD i konfiguracja Swagger UI.
3. **Budowa Frontendu** – tworzenie widoków oraz formularzy.
4. **Integracja** – połączenie frontendu z backendem.
5. **Deployment** – konteneryzacja aplikacji i wdrożenie w Azure.
6. **Testowanie** – testy jednostkowe i integracyjne.

---

## Architektura Systemu
- **Frontend:** Aplikacja MVC hostowana w kontenerze Azure.
- **Backend (API):** RESTful API hostowane w Azure.
- **Baza danych:** Azure SQL Database, zintegrowana z backendem.

---

## Linki

- **Backend API:** [Swagger UI](https://dziennikzywieniowybackendapi-fvf8bnepbfghabfk.polandcentral-01.azurewebsites.net/swagger/index.html)  
- **Aplikacja:** [Dziennik Żywieniowy](https://dziennikzywieniowy-hhcng7h9g8f3gebq.polandcentral-01.azurewebsites.net/)  
- **Prezentacja:** [YouTube](https://www.youtube.com/watch?v=QfPLMRlSa6c&ab_channel=Coderad)

---

## Podsumowanie
Projekt Dziennik Żywieniowy to kompleksowa aplikacja umożliwiająca zarządzanie dietą i aktywnością fizyczną. Dzięki zastosowaniu technologii takich jak ASP.NET Core, Docker i Microsoft Azure, aplikacja jest skalowalna, łatwa w utrzymaniu i dostarcza użytkownikom wartościowych funkcji.

W przyszłości planowany jest rozwój funkcji takich jak autoryzacja użytkowników, raportowanie oraz integracja z zewnętrznymi API fitness.
