# Nautilus Launcher

[cite_start]**Nautilus Launcher** je desktopová aplikace vytvořená v jazyce C#[cite: 6]. [cite_start]Slouží jako osobní organizér pro správu a rychlé spouštění `.exe` souborů[cite: 7].

---

## 🛠 Základní informace
* [cite_start]**Autor:** Fiala Adam (4.C) [cite: 4]
* [cite_start]**Téma:** Nautilus Launcher [cite: 4]
* [cite_start]**Technologie:** WPF, C#, XAML, JSON [cite: 4]
* [cite_start]**Termín odevzdání:** 5. 4. 2026 [cite: 4]

## 🚀 Hlavní funkce
* [cite_start]**Správa aplikací:** Uživatel může přidávat, přejmenovávat a mazat `.exe` soubory v seznamu[cite: 7, 28, 29].
* [cite_start]**Validace:** Aplikace ověřuje, zda se skutečně jedná o platný spustitelný soubor typu `.exe`[cite: 34].
* [cite_start]**Personalizace:** Ke každé položce lze nastavit vlastní obrázek/ikonu [cite: 35] [cite_start]a seznam lze libovolně řadit[cite: 32].
* [cite_start]**Zabezpečení:** Vstup do aplikace je chráněn login obrazovkou s uživatelským jménem a heslem[cite: 10, 27].
* [cite_start]**Ukládání dat:** Odkazy na soubory se ukládají do externího souboru pro trvalé uchování[cite: 8, 27].

## 📂 Struktura kódu
[cite_start]Projekt je organizován následovně[cite: 36]:
* [cite_start]`Login.xaml` / `Login.xaml.cs` – Přihlašovací rozhraní a jeho logika[cite: 37, 38].
* [cite_start]`MainWindow.xaml` / `MainWindow.xaml.cs` – Hlavní okno se seznamem aplikací[cite: 39, 40].
* [cite_start]`+---img` – Adresář pro uživatelské obrázky a ikony[cite: 45].

## 💻 Požadavky na prostředí a spuštění
1. [cite_start]**Závislosti:** Pro běh aplikace je nutné mít nainstalovaný .NET 8.0 Runtime[cite: 46, 55, 98].
2. [cite_start]**Instalace:** Stáhněte si vyexportovaný `.exe` balíček se všemi doprovodnými soubory[cite: 98].
3. [cite_start]**První spuštění:** Po spuštění aplikace se přihlaste (výchozí údaje lze změnit v nastavení)[cite: 33, 76].
4. [cite_start]**Použití:** Pomocí "Open File Dialog" vyberte aplikaci na disku, která se následně přidá do vašeho launcheru[cite: 79, 80].

## 📅 Časový harmonogram
* **1. [cite_start]Fáze (do 15. 3. 2026):** Tvorba dokumentace a funkčních požadavků[cite: 13, 14].
* **2. [cite_start]Fáze (do 22. 3. 2026):** Implementace logiky a práce s daty[cite: 16].
* **3. [cite_start]Fáze (do 29. 3. 2026):** Tvorba GUI ve WPF, testování a nápověda[cite: 18, 19].
* **4. [cite_start]Fáze (do 5. 4. 2026):** Finalizace logiky, dokumentace a příprava obhajoby[cite: 21, 22].

---
[cite_start]*Vytvořeno jako součást projektu do předmětu Programování a vývoj aplikací.* [cite: 1]