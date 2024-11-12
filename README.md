# R1_T07_02_Niz_Z020_Histogram
R1_T07_02_Niz_Z020_Histogram

// 1 WA
// https://petlja.org/sr-Latn-RS/kurs/14606/33/2763
// https://petlja.org/sr-Cyrl-RS/kurs/14606/6/1322
// https://petlja.org/biblioteka/r/problemi/Zbirka/histogram
// https://petlja.org/biblioteka/r/problemi/Zbirka-stara/histogram
// https://arena.petlja.org/competition/r1-07-nizovi-05-preslikavanja#tab_132994
// https://arena.petlja.org/competition/r1-07-nizovi-04-vektori-polinomi#tab_132710
// https://arena.petlja.org/competition/skola-od-kuce-nizovi1-zadaci#tab_97594
// https://learn.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings#BFormatString
// https://learn.microsoft.com/en-us/dotnet/standard/base-types/custom-numeric-format-strings
// https://github.com/draganilicnis/R1_T07_02_Niz_Z020_Histogram/blob/main/R1_T07_02_Niz_Z020_Histogram.cs

Ни у једном програмском језику не пролази 1 тест пример (6. тест пример), осим у Паскалу.
Ради само *.pas

6. тест пример:
8,23 11,08
8
90
и још 90 реалних бројева

Дакле а = 8.23, b = 11.08, а број подеока N je 8. 
Цео опсег је b - a = 11.08 - 8.23 = 2.85.
Када цео опсег поделимо на N, односно 8 подеока требало би да добијемо: 2.85 / 8 = 0.35625,
Међутим у C# добијамо да је dx = 0.35624999999999996,
па ће код друге итерације t = t + dx (у првој ће исправно да израчуна следећу вредност t)
да за t израчуна вредност: 8.942499999999999 уместо 8.9425, 
а заокруживањем на две децимале приказаће број 8.943, што би и требало да буде исправно, међутим само Паскал ће приказати 8.942, што су уредници и навели као исправн тест пример (а није).
