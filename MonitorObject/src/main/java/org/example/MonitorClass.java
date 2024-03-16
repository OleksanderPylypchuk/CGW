package org.example;

public class MonitorClass {
    private Object _object;
    public synchronized void Action() throws  InterruptedException{
        //some action
        notifyAll();
    }
    public synchronized void Action2() throws InterruptedException{
        while (_object==null){
            wait();
        }
        //action
    }
}
