## Piąte spotkanie Akademii C# 2017 - Interfejsy i struktury
Przykłady prezentowane na piatym spotkaniu Akademii C# wraz z prezentacją.

## Praca domowa:
- dodaj do projektu interfejs *IOrderProcessor* posiadający metodę *ProcessOrder* przyjmującą email i orderId
- dodaj klasę implementującą powyższy interfejs. Klasa ta powinna w konstruktorze pobierać *IDatabase* i *ISender*. Implementacja metody *ProcessOrder* powinna:
    - pobierać użytkownika z "bazy";
    - pobierać zamówienie (order) z "bazy";
    - wysyłać wiadomoć do użytkownika, że zrobił zamówienie o podanym id i nazwie.
