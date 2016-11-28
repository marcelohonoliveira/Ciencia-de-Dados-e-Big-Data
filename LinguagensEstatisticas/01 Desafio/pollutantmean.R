pollutantmean <- function (directory = "", pollutant = "", id)
{
  setwd(directory)
  
  dfFinal = data.frame(row.names = c("Date",	"sulfate", "nitrate", "ID"))
  
  for (idFile in id)
  {
    nameFile = paste0(paste0(rep("0", 3 - nchar(idFile)), collapse = ""), paste0(toString(idFile), ".csv"))
  
    dfTemp <- read.csv(file=nameFile, header=TRUE, sep=',', dec = ".")
   
    if(pollutant == "nitrate")
    {
      x <- !is.na(dfTemp$nitrate)
    }
    
    if(pollutant == "sulfate")
    {
      x <- !is.na(dfTemp$sulfate)
    }
    
    dfFil = dfTemp[x,]
    dfFinal <- rbind(dfFinal, dfFil)
  }
  
  vec <- dfFinal[[pollutant]]
  sum(vec)/length(vec)

}

directory <-"C:\\Users\\Marcelo\\Desktop\\Desafio Estatística\\specdata"
pollutant <- "nitrate"
id <- c(23)

pollutantmean(directory, pollutant, id)