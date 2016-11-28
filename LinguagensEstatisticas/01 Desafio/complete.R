complete <- function (directory = "", id)
{
  setwd(directory)
  
  dfFinal = data.frame(row.names = c("id",	"nobs"))
  
  for (idFile in id)
  {
    nameFile = paste0(paste0(rep("0", 3 - nchar(idFile)), collapse = ""), paste0(toString(idFile), ".csv"))
    
    dfTemp <- read.csv(file=nameFile, header=TRUE, sep=',', dec = ".")
    
    x <- !is.na(dfTemp$nitrate) & !is.na(dfTemp$sulfate)
    
    
    dfFil = dfTemp[x,]
    dfNobs <- data.frame(id = idFile, nobs = nrow(dfFil))
    
    dfFinal <- rbind(dfFinal, dfNobs)
  }
  
  dfFinal
}

directory <-"C:\\Users\\Marcelo\\Desktop\\Desafio Estatística\\specdata"
id <- c(3)

complete(directory, id)


