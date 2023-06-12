import './App.css';
import { read, utils, writeFile }  from 'xlsx'; //https://docs.sheetjs.com/docs/getting-started/installation/nodejs
import React, { useMemo, useCallback, useState, useRef } from "react";
import { AgGridReact } from 'ag-grid-react';

function App() {
  const [items, setItems] = useState([{editable: true}])
  var ws = [];

  const columns = [ 
    { field: 'Referencia', width:130, resizable: true, sortable: true, filter: 'agSetColumnFilter'},
    { field: 'Cliente', width:120, resizable: true, sortable: true },
    { field: 'Estado', width:90,  resizable: true, sortable: true },
    { field: 'Tipo', width:90, resizable: true, sortable: true },
    { field: 'Matricula', width:120, resizable: true, sortable: true },
    { field: 'TipoCarga', width:120, resizable: true, sortable: true },
    { field: 'Prioridade', width:120, resizable: true, sortable: true },
    { field: 'DataRegisto', width:120, resizable: true, sortable: true },
    { field: 'BlockedTime', width:120, resizable: true, sortable: true },
    { field: 'POD', width:90, resizable: true, sortable: true },
    { field: 'Parque', width:120, resizable: true, sortable: true },
    { field: 'TipoEquipamento', width:120, resizable: true, sortable: true },
    { field: 'DepotIdBlocking', width:120, resizable: true, sortable: true },
    { field: 'DataAtribExp', width:120, resizable: true, sortable: true },
    { field: 'Vessel', width:90, resizable: true, sortable: true },
    { field: 'Voyage', width:90, resizable: true, sortable: true },
    { field: 'POL', width:90, resizable: true, sortable: true }
  ];

  const gridRef = useRef(); // Optional - for accessing Grid's API

  const defaultColDef = useMemo(() => {
    return {
      sortable: true,
      filter: true,
      resizable: true,
      editable: true,
      flex: 1,
    };
  }, []);


  const handleOnExport = () => {
    var wb = utils.book_new(),
    ws = utils.json_to_sheet(items);
    utils.book_append_sheet(wb, ws, "Bookings");
    writeFile(wb, "excel1_31-12-2020_updated.xlsx");
  }

  const handleFile = (event) => {
    const file = event.target.files[0];
    const promisse=new Promise((resolve, reject)=>{
      const fileReader = new FileReader();
      fileReader.onload = (e) => {
        const bufferArray = e.target.result;
        const wb=read(bufferArray, {type:'array'});
        const wsname=wb.SheetNames[0];
        ws=wb.Sheets[wsname];
        const data = utils.sheet_to_json(ws,{
          raw: false 
        });
        resolve(data);
      };
      fileReader.readAsArrayBuffer(file);

      fileReader.onerror = (error) => {
        reject(error);
      };
    });
    promisse.then((d)=>{
      console.log(d);
      setItems(d);
    });
  }

  const onRowEditingStarted = useCallback((event) => {
    console.log('never called - not doing row editing');
  }, []);

  const onRowEditingStopped = useCallback((event) => {
    console.log('never called - not doing row editing');
  }, []);

  const onCellEditingStarted = useCallback((event) => {
    console.log('cellEditingStarted');
  }, []);

  const onCellEditingStopped = useCallback((event) => {
    console.log('cellEditingStopped');
  }, []);

  function GetValues(){
    const insertVal = {
      Referencia: document.getElementById("referenciaControl").value,
      Cliente: document.getElementById("clienteControl").value,
      Estado: document.getElementById("estadoControl").value,
      Tipo: document.getElementById("tipoControl").value,
      Matricula: document.getElementById("matriculaControl").value,
      TipoCarga: document.getElementById("tipoCargaControl").value,
      Prioridade: document.getElementById("prioridadeControl").value,
      DataRegisto: document.getElementById("dataRegistoControl").value,
      BlockedTime: document.getElementById("referblockedTimeControlenciaControl").value,
      POD: document.getElementById("podControl").value,
      Parque: document.getElementById("parqueControl").value,
      TipoEquipamento: document.getElementById("tipoEquipamentoControl").value,
      DepotIdBlocking: document.getElementById("depotIdBlockingControl").value,
      DataAtribExp: document.getElementById("dataAtribExpControl").value,
      Vessel: document.getElementById("vesselControl").value,
      Voyage: document.getElementById("voyageControl").value,
      POL: document.getElementById("polControl").value,
    };

    return insertVal
  };

  const addInfo = useCallback(() => { //https://www.ag-grid.com/react-data-grid/server-side-model-updating-transactions/
      const insertVal = GetValues();
      const transaction = {
        addIndex:-1,
        add: [insertVal],
      };
      gridRef.current.api.applyTransaction(transaction);
      items.push(insertVal);
  }, []);

  const deleteInfo = useCallback(()=> { //https://www.ag-grid.com/react-data-grid/server-side-model-updating-transactions/
    const selectedRows = gridRef.current.api.getSelectedNodes();
    console.log("data " + selectedRows[0].data.Referencia);
    const ind = items.findIndex(element => element.Referencia === selectedRows[0].data.Referencia);
    const transaction = { remove: [selectedRows[0].data]};
    gridRef.current.api.applyTransaction(transaction);
    items.slice(ind);
  }, []);

  function resetInfo () { //https://linuxhint.com/clear-input-fields-javascript/
    document.getElementById("referenciaControl").value="";
    document.getElementById("clienteControl").value="";
    document.getElementById("estadoControl").value="";
    document.getElementById("tipoControl").value=""; 
    document.getElementById("matriculaControl").value=""; 
    document.getElementById("tipoCargaControl").value=""; 
    document.getElementById("prioridadeControl").value=""; 
    document.getElementById("dataRegistoControl").value=""; 
    document.getElementById("blockedTimeControl").value=""; 
    document.getElementById("podControl").value=""; 
    document.getElementById("parqueControl").value=""; 
    document.getElementById("tipoEquipamentoControl").value=""; 
    document.getElementById("depotIdBlockingControl").value="";
    document.getElementById("dataAtribExpControl").value="";
    document.getElementById("vesselControl").value="";
    document.getElementById("voyageControl").value="";
    document.getElementById("polControl").value="";
  };
  
  return (
    <div className="App">
      <div class="container">
        <br></br>
        <div class="row">
          <div class="col">
            <input 
                class="form-control"
                type="file"
                name="file"
                accept=".csv,.xlsx"
                onChange={handleFile}
                style = {{display:"block"}}
            ></input> 
          </div>
          <div class="col-sm">
          <button  class="btn btn-primary"
              onClick={handleOnExport}
              style={{ marginBottom: '5px', fontWeight: 'bold' }}
          >
              Export to Excel
          </button>
        </div>
        </div>
      </div>  
      <br></br>
      <br></br>
    
      <form class="form-inline" id ="myform">
        <div class="form-group mb-4">
            <label style={{paddingLeft:52, paddingRight:23}}>Referencia</label>
            <input type="text" class="form-control" id ="referenciaControl"></input>
        </div>
        <div class="form-group mx-sm-3 mb-4">
            <label style={{paddingLeft:80, paddingRight:53}}>Cliente</label>
            <input type="text" class="form-control" id ="clienteControl"></input>
        </div>
        <div class="form-group mx-sm-3 mb-4">
            <label style={{paddingLeft:80, paddingRight:25}}>Estado</label>
            <input type="text" class="form-control" id ="estadoControl"></input>
        </div>
        <div class="form-group mx-sm-3 mb-4">
            <label style={{paddingLeft:60, paddingRight:50}}>Tipo</label>
            <input type="text" class="form-control" id ="tipoControl"></input>
        </div>
        <div class="form-group mx-sm-3 mb-4">
            <label style={{paddingLeft:45, paddingRight:20}}>Matricula</label>
            <input type="text" class="form-control" id ="matriculaControl"></input>
        </div>
        <div class="form-group mx-sm-3 mb-4">
            <label style={{paddingLeft:55, paddingRight:40}}>TipoCarga</label>
            <input type="text" class="form-control" id ="tipoCargaControl"></input>
        </div>
        <div class="form-group mx-sm-3 mb-4">
            <label style={{paddingLeft:50, paddingRight:30}}>Prioridade</label>
            <input type="text" class="form-control" id ="prioridadeControl"></input>
        </div>
        <div class="form-group mx-sm-3 mb-4">
            <label style={{paddingLeft:30, paddingRight:25}}>DataRegisto</label>
            <input type="text" class="form-control" id ="dataRegistoControl"></input>
        </div>
        <div class="form-group mx-sm-3 mb-4">
            <label style={{paddingLeft:20, paddingRight:22}}>BlockedTime</label>
            <input type="text" class="form-control" id ="blockedTimeControl"></input>
        </div>
        <div class="form-group mx-sm-3 mb-4">
            <label style={{paddingLeft:90, paddingRight:45}}>POD</label>
            <input type="text" class="form-control" id ="podControl"></input>
        </div>
        <div class="form-group mx-sm-3 mb-4">
            <label style={{paddingLeft:70, paddingRight:35}}>Parque</label>
            <input type="text" class="form-control" id ="parqueControl"></input>
        </div>
        <div class="form-group mx-sm-3 mb-4">
            <label style={{paddingRight:15}}>TipoEquipamento</label>
            <input type="text" class="form-control" id ="tipoEquipamentoControl"></input>
        </div>
        <div class="form-group mx-sm-3 mb-4">
            <label style={{paddingRight:15}}>DepotIdBlocking</label>
            <input type="text" class="form-control" id ="depotIdBlockingControl"></input>
        </div>
        <div class="form-group mx-sm-3 mb-4">
            <label style={{paddingLeft:50, paddingRight:25}}>DataAtribExp</label>
            <input type="text" class="form-control" id ="dataAtribExpControl"></input>
        </div>
        <div class="form-group mx-sm-3 mb-4">
            <label style={{paddingLeft:80, paddingRight:30}}>Vessel</label>
            <input type="text" class="form-control" id ="vesselControl"></input>
        </div>
        <div class="form-group mx-sm-3 mb-4">
            <label style={{paddingLeft:70, paddingRight:20}}>Voyage</label>
            <input type="text" class="form-control" id ="voyageControl"></input>
        </div>
        <div class="form-group mx-sm-3 mb-4">
            <label style={{paddingLeft:85, paddingRight:20}}>POL</label>
            <input type="text" class="form-control" id ="polControl"></input>
        </div>
      </form>
      
      <div class="container">
        <br></br>
        <div class="row">
          <div class="col-3">
            <button type="button" class="btn btn-success" onClick={addInfo}>Add</button>
          </div>
          <div class="col-3">
            <button type="button" class="btn btn-info" onClick={resetInfo}>Reset</button>
          </div>
          <div class="col-3">
            <button type="button" class="btn btn-danger" onClick={deleteInfo}>Remove</button>
          </div>
        </div>
      </div>

      <br></br>

      <div className='ag-theme-alpine-dark' style={{height:800, width:2000}}>
          <AgGridReact 
            ref={gridRef}
            rowData={items}
            rowSelection='single'
            animateRows='true'
            columnDefs={columns}
            defaultColDef={defaultColDef}
            onRowEditingStarted={onRowEditingStarted}
            onRowEditingStopped={onRowEditingStopped}
            onCellEditingStarted={onCellEditingStarted}
            onCellEditingStopped={onCellEditingStopped}
          ></AgGridReact>
      </div>
    </div>
  );
}

export default App;
