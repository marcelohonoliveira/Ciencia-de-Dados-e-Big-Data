corr <- function (directory = "", lim)
{
  setwd(directory)
  id <- c(1:332)
  
  
  dfComplete = data.frame(row.names = c("Date",	"sulfate", "nitrate", "ID"))
  dfNobs = data.frame(row.names = c("ID",	"nobs"))
  
  for (idFile in id)
  {
    nameFile = paste0(paste0(rep("0", 3 - nchar(idFile)), collapse = ""), paste0(toString(idFile), ".csv"))
    
    dfTemp1 <- read.csv(file=nameFile, header=TRUE, sep=',', dec = ".")
    
    x <- !is.na(dfTemp1$nitrate) & !is.na(dfTemp1$sulfate)
    dfFil = dfTemp1[x,]
    
    dfComplete <- rbind(dfComplete, dfFil)
    
    dfTemp2 <- data.frame(ID = idFile, nobs = nrow(dfFil))
    dfNobs <- rbind(dfNobs, dfTemp2)
  }
  
  y <- dfNobs$nobs >= lim
  
  dfNobsFinal <- dfNobs[y,]
  
  dfMerge <- merge(dfComplete, dfNobsFinal, by.x = "ID", by.y = "ID" )
  
  cor(dfMerge$sulfate, dfMerge$nitrate)
}

directory <-"C:\\Users\\Marcelo\\Desktop\\Desafio Estatística\\specdata"
lim <- 150

corr(directory, lim)










