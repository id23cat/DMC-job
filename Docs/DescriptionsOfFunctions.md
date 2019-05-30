# **Set of functions from Weka libriaries**

## Problem on weka libriaries
!!! Need interface that have methods **getName, getDescription, exucute, setArgs**

Function on this set:

1. Weka_Normalize
2. Weka_Standartize
3. Weka_CSVLoader
4. Weka_CSVSaver
5. Weka_PCA
6. Weka_KMeansClustering

## **1. Normalization**

1.1 ***setArgs***

    Arguments: String "linkOnData"
    Description: set arguments for PCA
    Return value: -

1.2 ***getName***

    Arguments: -
    Description: get name of function
    Return value: String "name"

1.3 ***getDescription***

    Arguments: -
    Description: get Description of function
    Return value: String "description"

1.4 ***exucute***

    Arguments: -
    Description: normalize set of data
    Return value: String "linkOnData"

1.5 ***getAllValuesAsDoubleAt***

    Arguments: Number "valuesAsDouble"
    Description: get all values on array that equals as "valuesAsDouble".
    Return value: Number[] "result"

## **2. Standartization**

2.1 ***setArgs***

    Arguments: String "linkOnData"
    Description: set arguments for PCA
    Return value: -

2.2 ***getName***

    Arguments: -
    Description: get name of function
    Return value: String "name"

2.3 ***getDescription***

    Arguments: -
    Description: get Description of function
    Return value: String "description"

2.4 ***exucute***

    Arguments: -
    Description: normalize set of data
    Return value: String "linkOnData"

2.5 ***getAllValuesAsDoubleAt***

    Arguments: Number "valuesAsDouble"
    Description: get all values on array that equals as "valuesAsDouble".
    Return value: Number[] "result"

## **3. CSVLoader**

3.1 ***get***

    Arguments: -
    Description: get data from CSV
    Return value: -

3.2 ***restart***

    Arguments: -
    Description: clear CSVLoared
    Return value: -

3.3 ***setSource***

    Arguments: String "source"
    Description: set source for model?
    Return value: bool // In this moment return CSVLoader

3.4 ***getHead***

    Arguments: -
    Description: returns header (if present in file otherwise generated) and first line of data
    Return value: String "allInfoOnString"

3.5 ***execute***

    Arguments: -
    Description: set attributes and load dataset.
    Return value: -

3.6 ***getName***

    Arguments: -
    Description: get name of function
    Return value: String "name"

3.7 ***getDescription***

    Arguments: -
    Description: get Description of function
    Return value: String "description"

3.8 ***getArgsCount***

    Arguments: -
    Description: get number of arguments
    Return value: Number "countOfArgument"

3.9 ***getLinkOnResult***

    Arguments: -
    Description: get link on database
    Return value: String "linkOnResult"

3.10 ***hasHeader***

    Arguments: -
    Description: get link on database
    Return value: ? //now return CSVLoader

3.11 ***GetHasHeader***

    Arguments: -
    Description: get link on database
    Return value: Bool "hasHeader"

3.12 ***asDate***

    Arguments: Number "index"
    Description: set data attribute
    Return value: - ? //now return CSVLoader

3.13 ***setDateFormat***

    Arguments: String "format"
    Description: set format for data
    Return value: - ? //now return CSVLoader

3.14 ***asNumeric***

    Arguments: Number "index"
    Description: set numeric attribute
    Return value: - ? //now return CSVLoader

3.15 ***asNominal***

    Arguments: Number "index"
    Description: set nominal attribute
    Return value: - ? //now return CSVLoader

3.16 ***asString***

    Arguments: Number "index"
    Description: set string attribute
    Return value: - ? //now return CSVLoader

## **4. CSVSaver**

4.1 ***save***

    Arguments: String "linkOnData"
    Description: save data in file
    Return value: -

4.2 ***setDestination***

    Arguments: String "filename"
    Description: create file for new data
    Return value: -

4.3 ***exucute***

    Arguments: -
    Description: save data on file
    Return value: String "linkOnData"

4.4 ***getName***

    Arguments: -
    Description: get name of function
    Return value: String "name"

4.5 ***getDescription***

    Arguments: -
    Description: get Description of function
    Return value: String "description"

4.6 ***getArgsCount***

    Arguments: -
    Description: get number of arguments
    Return value: Number "countOfArgument"

4.7 ***setArgs***

    Arguments: String[] "listOfArgs"
    Description: set list of arguments
    Return value: -

4.8 ***getResult***

    Arguments: -
    Description: get result as string
    Return value: String "result"

## **5. PrincipCompAnalysis**

5.1 ***setArgs***

    Arguments: String "linkOnData"
    Description: set arguments for PCA
    Return value: -

5.2 ***getName***

    Arguments: -
    Description: get name of function
    Return value: String "name"

5.3 ***getDescription***

    Arguments: -
    Description: get Description of function
    Return value: String "description"

5.4 ***exucute***

    Arguments: -
    Description: exucute principCompAnalysis
    Return value: String "linkOnData"

5.5 ***getResult***

    Arguments: -
    Description: get Data after principCompAnalysis
    Return value: String "linkOnData"

## **6. KMeansClustering**

6.1 ***showInfo***

    Arguments: -
    Description: output all of information on consol.
    Return value: -

6.2 ***evaluate***

    Arguments: String "dataLink"
    Description: evaluating of cluster
    Return value: -

6.3 ***getName***

    Arguments: -
    Description: get name of function
    Return value: String "name"

6.4 ***getDescription***

    Arguments: -
    Description: get Description of function
    Return value: String "description"

6.5 ***train***

    Arguments: -
    Description: function for training the set of data
    Return value: String "linkOnData"
