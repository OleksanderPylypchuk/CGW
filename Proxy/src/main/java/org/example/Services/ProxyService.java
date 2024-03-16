package org.example.Services;

import org.example.Services.IServices.IService;

public class ProxyService implements IService {
    private Service _service;
    public ProxyService(Service service){
        _service=service;
    }
    @Override
    public void Action(Object obj) {
        if(obj!=null){ //checking if request is valid
            _service.Action(obj);
        }
    }
}
