package org.example;

public class LazyClass {
    private ExpenciveClass _expenciveClass;

    public ExpenciveClass get_expenciveClass() {
        if(_expenciveClass==null){
            _expenciveClass=new ExpenciveClass();
        }
        return _expenciveClass;
    }
}
