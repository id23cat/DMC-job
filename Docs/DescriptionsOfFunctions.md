# **Set of functions from Weka libriaries**

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
