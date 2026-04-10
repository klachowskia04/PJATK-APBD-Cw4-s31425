Co zostało zrobione:
usunięto walidację z SubscriptionRenewalService
utworzono:
InterfaceInputValidator
ImplementationInputValidator
Efekt:
walidacja została oddzielona od logiki biznesowej
klasa główna stała się prostsza

Krok 2 – Wydzielenie repozytoriów
Co zostało zrobione:
zamiast bezpośredniego użycia:
CustomerRepository
SubscriptionPlanRepository
wprowadzono abstrakcje:
CustomerDataSource
SubscriptionPlanDataSource
Efekt:
zmniejszono zależność od konkretnych klas
umożliwiono łatwą podmianę źródła danych

Krok 3 – Opakowanie LegacyBillingGateway
Co zostało zrobione:
usunięto bezpośrednie wywołania klasy statycznej
utworzono:
BillingService 
LegacyBillingService 
Efekt:
kod nie zależy już bezpośrednio od klasy statycznej
poprawiono testowalność
spełniono wymaganie zadania dotyczące legacy

Krok 4 – Eliminacja if-else
Co zostało zrobione:

Rozbito logikę warunkową na osobne klasy.

Opłaty wsparcia:
PlanSupportFeeService (START)
ProPlanSupportFeeService (PRO)
EnterpriseSupportFeeService (ENTERPRISE)
Opłaty płatności:
CardPaymentService
InvoicePaymentService
Dodatkowo:
w SubscriptionRenewalService wprowadzono listy strategii
wybór odpowiedniej logiki odbywa się dynamicznie
Efekt:
usunięto rozbudowane if-else
dodanie nowego typu nie wymaga zmiany istniejącego kodu

Po refaktoryzacji:

każda klasa ma jedną odpowiedzialność
zmniejszono coupling
zwiększono czytelność
łatwo rozszerzać system
