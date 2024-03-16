public class FeatureCollection 
{
    // Todo Earthquake Problem - ADD YOUR CODE HERE
    // Create additional classes as necessary
    public List<Feature> Features { get; set; }
}

public class Feature
{
    public PropertiesClass properties { get; set; }
}

public class PropertiesClass
{
    public string place { get; set; }
    public double mag { get; set; }
}