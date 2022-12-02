import React, { useEffect, useState } from 'react';
import './App.css';
import axios from 'axios';
import MaterialTable from 'material-table';

function App() {  
  const [peoplesDetails, setPeoplesDetails] = useState<any>([]);

  const getData = async () => {
    const { data } = await axios.get(`/api/PeoplesDetails`);
    setPeoplesDetails(data);
  };
  useEffect(() => {
    getData();
  }, []);

  return (
    <div className='custom-container'>
    <MaterialTable
      title="Peoples Deatils Data"
      columns={[
        { title: 'FIRST NAME', field: 'firstName' },
        { title: 'LAST NAME', field: 'lastName' },
        { title: 'DOB', field: 'dataofBirth' },
        { title: 'EMAIL', field: 'email' },
        { title: 'ADDRESS', field: 'address' },
        { title: 'CITY', field: 'city' },
        { title: 'COUNTRY', field: 'country' },
        { title: 'POSTAL CODE', field: 'zipCode' },
      ]}
      data = {peoplesDetails}
    />
    </div>

  )
}

export default App;
