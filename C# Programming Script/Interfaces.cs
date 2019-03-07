using System.Collections.Generic;
using System;

public class AlertService
    {
 private readonly AlertDAO storage = new AlertDAO();
        IAlertDAO ialertDAO;
        public AlertService(IAlertDAO ialertDAO)
        {
            this.ialertDAO = ialertDAO;
        }
        public Guid RaiseAlert()
        {
            return ialertDAO.AddAlert(DateTime.Now);
        }

        public DateTime GetAlertTime(Guid id)
        {
            return ialertDAO.GetAlert(id);
        }
    }
	
public class AlertDAO : IAlertDAO
{
    private readonly Dictionary<Guid, DateTime> alerts = new Dictionary<Guid, DateTime>();
	
    public Guid AddAlert(DateTime time)
    {
        Guid id = Guid.NewGuid();
        this.alerts.Add(id, time);
        return id;
    }
	
    public DateTime GetAlert(Guid id)
    {
        return this.alerts[id];
    }	
}

public interface IAlertDAO {
    Guid AddAlert(DateTime time);
    DateTime GetAlert(Guid id);
}