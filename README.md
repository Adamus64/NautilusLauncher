# Nautilus Launcher

**Nautilus Launcher** je desktopová aplikace vytvořená v jazyce C#. Slouží jako osobní organizér pro správu a rychlé spouštění .exe souborů z jednoho přehledného rozhraní.

---

## 🛠 Základní informace
* **Autor:** Adam Fiala (4.C)
* **Téma:** Nautilus Launcher
* **Technologie:** WPF, C#, XAML, JSON / Textové ukládání
* **Termín odevzdání:** 5. 4. 2026

## 🚀 Hlavní funkce
* **Správa aplikací:** Uživatel může do seznamu přidávat .exe soubory, přejmenovávat je nebo je mazat.
* **Validace:** Systém automaticky ověřuje, zda vkládaný soubor má správnou koncovku .exe.
* **Personalizace:** Možnost nastavit si u každé položky vlastní obrázek a libovolně si řadit seznam aplikací.
* **Zabezpečení:** Aplikace je chráněna login obrazovkou, kde se uživatel musí přihlásit jménem a heslem.
* **Ukládání dat:** Cesty k souborům se ukládají do textového souboru, aby zůstaly dostupné i po restartu aplikace.

## 📂 Struktura projektu
* `Login.xaml` / `Login.xaml.cs` – Přihlašovací rozhraní a správa uživatelských údajů.
* `MainWindow.xaml` / `MainWindow.xaml.cs` – Hlavní okno s navigací a seznamem aplikací.
* `+---img` – Adresář určený pro uživatelské obrázky a ikony.

## 💻 Požadavky na prostředí
1. **Závislosti:** Pro běh aplikace je nutné mít nainstalované prostředí .NET 8.0 Runtime.
2. **Instalace:** Stáhněte si vyexportovaný .exe balíček společně se všemi doprovodnými soubory.
3. **První spuštění:** Po spuštění se přihlaste (údaje lze následně změnit v nastavení aplikace).
4. **Použití:** Pomocí integrovaného Průzkumníka souborů (Open File Dialog) vyberte .exe soubor, který chcete přidat do svého launcheru.

## 📅 Časový harmonogram
* **1. Fáze (do 15. 3. 2026):** Dokumentace, funkční požadavky a návrh UI.
* **2. Fáze (do 22. 3. 2026):** Grafické rozhraní ve WPF, testování a nápověda.
* **3. Fáze (do 29. 3. 2026):** Implementace logiky a práce s daty.
* **4. Fáze (do 5. 4. 2026):** Finalizace logiky, dokumentace a příprava na obhajobu.

---
*Vytvořeno jako maturitní/ročníkový projekt do předmětu Programování a vývoj aplikací.*