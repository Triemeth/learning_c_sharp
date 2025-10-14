using System;

public interface INueronSignal{
    double Output{get; set;}
}


public interface INueronReceptor{
    Dictionary<INueronSignal, NeuralFactor>Input{get;}
}

public class NeuralFactor{
    #region Constructors
    public NeuralFactor(double weight){
        m_weight = weight;
        m_delta = 0;
    }
    #endregion

    #region Member Variables
    private double m_weight;
    private double m_delta;
    #endregion

    #region Properties
    public double
    
}