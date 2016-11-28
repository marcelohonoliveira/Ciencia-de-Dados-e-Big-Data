install.packages("benford.analysis")

library(benford.analysis) 


directory <-"E:\\Google Drive\\02 Pós CDBD\\02 ILE - Introdução às Linguagens Estatísticas\\04 Trabalhos\\02 Artigo - Lei Benford\\02 Análise em R"

setwd(directory)


arquivo1 <- 'MCMV.csv'

dfMCMV <- read.csv(file=arquivo1, header=TRUE, sep=',', dec=".")

benford_MCMV <- benford(dfMCMV$Valor, number.of.digits=1)

plot(benford_MCMV)


arquivo2 <- 'PAC_2016_06.csv'

dfPAC <- read.csv(file=arquivo2, header=TRUE, sep=',', dec=".")

benford_PAC <- benford(dfPAC$investimento_total, number.of.digits=1)

plot(benford_PAC)


