import { useState, useEffect } from 'react'
import axios from 'axios'
import loadConfig from '../../../loadConfig'
const config = loadConfig()

const Database = () => {
  // URL
  const [eqcMfMachine, setEqcMfMachine] = useState(null)
  const url = `http://${config.apiBaseUrl}:5147/api/db/${eqcMfMachine}`
  //
  // DATA
  const [eqcData, setEqcData] = useState([]) // data from eqc
  const [totalRecords, setTotalRecords] = useState(0) //total records
  //  SORT
  const [dateFrom, setDateFrom] = useState('') // from date
  const [dateTo, setDateTo] = useState('') // to date
  const [isDescending, setIsDescending] = useState(true) // descending ascending
  const [toolNum, setToolNum] = useState('') // filter tool number

  const [pageNumber, setPageNumber] = useState(1)
  const [pageSize] = useState(20)
  const [loadingData, setLoadingData] = useState(true)

  // GET DATA FROM DB
  const fetchData = async () => {
    try {
      setLoadingData(true)
      const response = await axios.get(url, {
        params: {
          DateFrom: dateFrom,
          DateTo: dateTo,
          IsDecsending: isDescending,
          ToolNum: toolNum,
          PageNumber: pageNumber,
          PageSize: pageSize,
        },
      })
      var data = await response.data
      setEqcData(data.eqcdb)
      setTotalRecords(data.totalRecords)
      setLoadingData(false)
      console.log(data)
    } catch (error) {
      setLoadingData(false)
      console.log(error.response)
    }
  }

  useEffect(() => {
    if (eqcMfMachine === '' || eqcMfMachine === null) {
      setEqcData([])
      setTotalRecords(0)
      setLoadingData(false)
    } else {
      fetchData()
    }
  }, [isDescending, toolNum, pageNumber, pageSize, dateFrom, dateTo, eqcMfMachine]) // Aktualizácia dát pri zmene filtrov

  useEffect(() => {
    window.scrollTo({ top: 0, behavior: 'smooth' })
    if (eqcData.length === 0) {
      setPageNumber(1)
    }
  }, [pageNumber, eqcData, dateTo, dateFrom, isDescending, toolNum])

  const handleDateFromChange = (event) => {
    let dateFrom = event.target.value
    setDateFrom(dateFrom)
    setPageNumber(1)
    console.log(dateFrom)
  }

  const handleDateToChange = (event) => {
    let dateTo = event.target.value
    setDateTo(dateTo)
    setPageNumber(1)
  }

  const handleIsDescendingChange = (event) => {
    setIsDescending(event.target.checked)
    setPageNumber(1)
  }

  const handleToolNumChange = (event) => {
    const num = parseInt(event.target.value)
    if (num >= 0) {
      setToolNum(num)
    } else {
      setToolNum()
    }
    setPageNumber(1)
  }

  const handleMachineChoose = (event) => {
    const machine = event.target.value
    setEqcMfMachine(machine)
    setPageNumber(1)
  }

  const tools = [
    { value: '', label: 'All_Tools' },
    { value: '1', label: 'Tool_1' },
    { value: '2', label: 'Tool_2' },
    { value: '3', label: 'Tool_3' },
    { value: '4', label: 'Tool_4' },
    { value: '5', label: 'Tool_5' },
    { value: '6', label: 'Tool_6' },
    { value: '7', label: 'Tool_7' },
    { value: '8', label: 'Tool_8' },
    { value: '9', label: 'Tool_9' },
    { value: '10', label: 'Tool_10' },
    { value: '11', label: 'Tool_11' },
    { value: '12', label: 'Tool_12' },
    { value: '13', label: 'Tool_13' },
    { value: '14', label: 'Tool_14' },
    { value: '15', label: 'Tool_15' },
    { value: '16', label: 'Tool_16' },
    { value: '17', label: 'Tool_17' },
    { value: '18', label: 'Tool_18' },
    { value: '19', label: 'Tool_19' },
    { value: '20', label: 'Tool_20' },
  ]

  const machines = [
    { value: '', label: 'Choose machine' },
    { value: 'eqc1', label: 'EQC_MF_1' },
    { value: 'eqc2', label: 'EQC_MF_2' },
    { value: 'eqc3', label: 'EQC_MF_3' },
    { value: 'eqc4', label: 'EQC_MF_4' },
    { value: 'eqc5', label: 'EQC_MF_5' },
    { value: 'eqc6', label: 'EQC_MF_6' },
    { value: 'eqc7', label: 'EQC_MF_7' },
    { value: 'eqc8', label: 'EQC_MF_8' },
  ]

  return (
    <div className='section flex flex-col lg:mx-20 mx-2'>
      {/*  */}
      <div className='flex flex-col items-center text-base my-4 mt-[0px]'>
        <label htmlFor='dateTo'>Selected MF machine:</label>
        <select
          name={toolNum}
          onChange={handleMachineChoose}
          className='text-2xl md:text-4xl mx-2 p-1 rounded-sm font-bold px-4 text-black/80 bg-secondary ring-secondary ring-4 text-center cursor-pointer'
        >
          {machines.map((option) => (
            <option key={option.value} value={option.value} className='cursor-pointer'>
              {option.label}
            </option>
          ))}
        </select>
      </div>
      {/*  */}
      {/* SORT */}
      <div className='flex flex-col lg:flex-row lg:space-x-10 -lg:space-y-4 border-l-4 border-collor1 pb-4 gap-y-2'>
        <div className='flex flex-row px-2 gap-x-2'>
          {/* date from */}
          <div className='text-base flex flex-col items-center'>
            <label htmlFor='dateFrom'>Date from:</label>
            <input
              type='datetime-local'
              onChange={handleDateFromChange}
              className='rounded-sm text-collor1 px-1 cursor-pointer'
            />
          </div>
          {/* date to  */}
          <div className='text-base flex flex-col items-center'>
            <label htmlFor='dateTo'>Date to:</label>
            <input type='datetime-local' onChange={handleDateToChange} className='rounded-sm text-collor1 px-1 cursor-pointer' />
          </div>
        </div>
        {/* select tool  */}
        <div className='flex flex-col items-center text-base'>
          <label htmlFor='dateTo'>Selected Tool:</label>
          <select
            name={toolNum}
            onChange={handleToolNumChange}
            className='text-xl mx-2 px-10 rounded-sm text-collor1 cursor-pointer'
          >
            {tools.map((option) => (
              <option key={option.value} value={option.value} className=''>
                {option.label}
              </option>
            ))}
          </select>
        </div>
        {/* descending */}
        <div className='text-base flex flex-col items-center'>
          <label htmlFor='isDescending'>Is Descending:</label>
          <input
            type='checkbox'
            id='isDescending'
            defaultChecked={true}
            className='mx-2 align-middle size-5 rounded-md text-collor1 cursor-pointer'
            onChange={handleIsDescendingChange}
          />
        </div>
        {/* show records  */}
        <div className='flex flex-row items-center h2 text-3xl max-lg:mt-8 justify-center my-auto'>
          <h2 className='text-collor2 pr-2'>{totalRecords}</h2>
          Records
        </div>
      </div>
      {/*  */}
      {/* LOADING */}
      <div className={`${loadingData ? 'flex' : 'hidden'} text-collor1 flex flex-col items-center animate-pulse text-2xl `}>
        <img src='/loading.svg' alt='loading data' className='size-[100px] md:size-[200px]' />
        <span>Loading...</span>
      </div>
      {/*  */}
      {/*  */}
      {/* DB */}
      {/*  */}
      <div className='mt-10 text-base md:text-xl font-light normal-case h3 min-h-screen'>
        {eqcData.length === 0 ? (
          <h2 className='mx-auto text-center'>No Data</h2>
        ) : (
          <div className='space-y-5'>
            {eqcData.map((item) => (
              <div key={item.id} className='flex flex-wrap border border-primary/20 rounded-lg p-2'>
                <p>
                  <span className='text-primary '>ID:</span> {item.id} <span className='text-collor1'> | </span>
                </p>
                <p>
                  <span className='text-primary '> Time shot:</span>{' '}
                  <span className='text-yellow-300'>
                    {new Date(item.timeStamp).toLocaleDateString('sk-SK', {
                      day: 'numeric',
                      month: 'numeric',
                      year: 'numeric',
                    })}{' '}
                    {new Date(item.timeStamp).toLocaleTimeString('sk-SK', {
                      hour: 'numeric',
                      minute: 'numeric',
                      second: 'numeric',
                    })}
                  </span>
                  <span className='text-collor1'> | </span>
                </p>
                <p>
                  <span className='text-primary '> Tool name:</span> {item.actualToolName && item.actualToolName.replace('?', '')}
                  <span className='text-collor1'> | </span>
                </p>
                <p>
                  <span className='text-primary '> Tool num:</span> {item.toolNumber} <span className='text-collor1'> | </span>
                </p>
                <p>
                  <span className='text-primary '> Cycle time:</span> {item.cycleTime} <span className='text-collor1'> | </span>
                </p>
                <p>
                  <span className='text-primary '>Pressure bluemelt:</span> {item.actualPressure}{' '}
                  <span className='text-collor1'> | </span>
                </p>
                <p>
                  <span className='text-primary '> Nozzle_1 Outside:</span> {item.actual_AirOutside1}{' '}
                  <span className='text-collor1'> | </span>
                </p>
                <p>
                  <span className='text-primary '> Nozzle_1 Inside:</span> {item.actual_AirInside1}{' '}
                  <span className='text-collor1'> | </span>
                </p>
                <p>
                  <span className='text-primary '> Nozzle_2 Outside:</span> {item.actual_AirOutside2}{' '}
                  <span className='text-collor1'> | </span>
                </p>
                <p>
                  <span className='text-primary '> Nozzle_2 Inside:</span> {item.actual_AirInside2}{' '}
                  <span className='text-collor1'> | </span>
                </p>
                <p>
                  <span className='text-primary '> Set nozzle_1 Outside:</span> {item.setAirOutside1}{' '}
                  <span className='text-collor1'> | </span>
                </p>
                <p>
                  <span className='text-primary '> Set nozzle_1 inside:</span> {item.setAirInside1}{' '}
                  <span className='text-collor1'> | </span>
                </p>
                <p>
                  <span className='text-primary '> Set nozzle_2 outside:</span> {item.setAirOutside2}{' '}
                  <span className='text-collor1'> | </span>
                </p>
                <p>
                  <span className='text-primary '> Set nozzle_2 inside:</span> {item.setAirInside2}{' '}
                  <span className='text-collor1'> | </span>
                </p>

                <p>
                  <span className='text-primary '> Set nozzle_1 pump:</span> {item.setpumpSpeed1}{' '}
                  <span className='text-collor1'> | </span>
                </p>
                <p>
                  <span className='text-primary '> Set nozzle_2 pump:</span> {item.setpumpSpeed2}{' '}
                  <span className='text-collor1'> | </span>
                </p>
                <p>
                  <span className='text-primary '> Set nozzle_3 pump:</span> {item.setpumpSpeed3}{' '}
                  <span className='text-collor1'> | </span>
                </p>
                <p>
                  <span className='text-primary '>Gripper connected:</span> {item.robotConnectedGripper}{' '}
                  <span className='text-collor1'> | </span>
                </p>
                <p>
                  <span className='text-primary '> Gripper tool num:</span> {item.robotToolNumber}{' '}
                  <span className='text-collor1'> | </span>
                </p>
                <p>
                  <span className='text-primary '> Heater ok:</span> {item.heaterOk} <span className='text-collor1'> | </span>
                </p>
              </div>
            ))}
          </div>
        )}
      </div>
      {/*  */}
      {/* pagination */}
      <div className='flex flex-row gap-x-6 mx-auto justify-center items-center'>
        <button
          onClick={() => setPageNumber(pageNumber - 1)}
          className={`${pageNumber == 1 ? 'invisible' : 'block'} btn_2 px-2 w-[100px]`}
        >
          Previous Page
        </button>
        <p className='my-auto text-xl md:text-4xl text-center w-fit'>
          Page: <span className='text-collor1 text-2xl md:text-4xl'>{pageNumber}</span>
        </p>
        <button
          onClick={() => setPageNumber(pageNumber + 1)}
          className={`${eqcData.length < pageSize ? 'invisible' : 'block'} btn_2 px-2 w-[100px]`}
        >
          Next Page
        </button>
      </div>
    </div>
  )
}
export default Database
