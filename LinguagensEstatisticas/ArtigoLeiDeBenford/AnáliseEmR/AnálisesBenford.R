install.packages("benford.analysis")

library(benford.analysis) 


directory <-"E:\\Google Drive\\02 P�s CDBD\\02 ILE - Introdu��o �s Linguagens Estat�sticas\\04 Trabalhos\\02 Artigo - Lei Benford\\02 An�lise em R"

setwd(directory)


arquivo1 <- 'MCMV.csv'

dfMCMV <- read.csv(file=arquivo1, header=TRUE, sep=',', dec=".")

benford_MCMV <- benford(dfMCMV$Valor, number.of.digits=1)

plot(benford_MCMV)


arquivo2 <- 'PAC_2016_06.csv'

dfPAC <- read.csv(file=arquivo2, header=TRUE, sep=',', dec=".")

benford_PAC <- benford(dfPAC$investimento_total, number.of.digits=1)

plot(benford_PAC)


