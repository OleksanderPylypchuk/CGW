package org.example;

import org.example.interfaces.IMethod;

public class Calc {
    public IMethod _method;
    public Calc(IMethod method){
        _method=method;
    }
    public void Calculation(int A, int B){
        _method.Action(A,B);
    }
}
