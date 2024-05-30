import axios from 'axios'
import { useEffect, useState } from 'react'
import { PiExportLight } from 'react-icons/pi'
import loadConfig from '../../../loadConfig'
import * as XLSX from 'xlsx'
import { data } from 'autoprefixer'
const config = loadConfig()

const Db_opelMachines = () => {
  //URL
  const [opelMachine, setOpelMachine] = useState(null)
  const url = `http://${config.apiBaseUrl}:5147/api/db/${opelMachine}`
  //
  // DATA
  const [opelData, setOpelData] = useState([])
  const [totalRecords, setTotalRecords] = useState(0)
  // SORT
  const [dateFrom, setDateFrom] = useState('') // from date
  const [dateTo, setDateTo] = useState('') // to date
  const [tempFrom, setTempFrom] = useState('')
  const [tempTo, setTempTo] = useState('')
  const [isDescending, setIsDescending] = useState(true) // descending ascending
  const [toolNum, setToolNum] = useState('') // filter tool number

  const [pageNumber, setPageNumber] = useState(1)
  const [pageSize, setPageSize] = useState(20)
  const [loadingData, setLoadingData] = useState(true)

  //GET DATA FROM DB
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
          TempFrom: tempFrom,
          TempTo: tempTo,
        },
      })
      var data = await response.data
      console.log(data)
      setOpelData(data.opelData)
      setTotalRecords(data.totalRecords)
      setLoadingData(false)
    } catch (error) {
      setLoadingData(false)
      console.log(error.response)
    }
  }

  //USE EFFECT
  useEffect(() => {
    if (opelMachine === '' || opelMachine === null) {
      setOpelData([])
      setTotalRecords(0)
      setLoadingData(false)
    } else {
      fetchData()
    }
  }, [opelMachine, isDescending, toolNum, pageNumber, pageSize, dateFrom, dateTo, pageSize, tempFrom, tempTo])

  useEffect(() => {
    window.scrollTo({ top: 0, behavior: 'smooth' })
    if (opelData.length === 0) {
      setPageNumber(1)
    }
  }, [pageNumber, opelData, dateTo, dateFrom, isDescending, toolNum, pageSize])

  //HANDLE
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

  const handleWaterTempFromChange = (event) => {
    let num = event.target.value
    if (num >= 0) {
      setTempFrom(num)
    } else {
      setTempFrom(0.0)
    }
    setPageNumber(1)
    console.log(`temp from ${num}`)
  }

  const handleWaterTempToChange = (event) => {
    let num = event.target.value
    if (num >= 0) {
      setTempTo(num)
    } else {
      setTempTo(100.0)
    }
    setPageNumber(1)
    console.log(`temp to ${num}`)
  }

  const handleMachineChoose = (event) => {
    const machine = event.target.value
    setOpelMachine(machine)
    setPageNumber(1)
  }

  const tools = [
    { value: '', label: 'All_Tools' },
    { value: '96', label: 'Opel Armrest FR mould' },
    { value: '97', label: 'Opel Armrest RR mould' },
    //     { value: '98', label: 'Opel Insert FR mould' },
    //     { value: '99', label: 'Opel Insert RR mould' },
  ]

  const machines = [
    { value: '', label: 'Choose machine' },
    { value: 'opelArmrestFR', label: 'Armrest Front' },
    { value: 'opelArmrestRR', label: 'Armrest Rear' },
    //     { value: 'opelInsertFR', label: 'Insert Front' },
    //     { value: 'opelInsertRR', label: 'Insert Rear' },
  ]

  const handleExport = () => {
    // Vytvorenie nového pracovného zošita
    const worksheet = XLSX.utils.json_to_sheet(opelData)
    const workbook = XLSX.utils.book_new()
    XLSX.utils.book_append_sheet(workbook, worksheet, 'Data')

    // Vytvorenie súboru a jeho stiahnutie
    const excelBuffer = XLSX.write(workbook, { bookType: 'xlsx', type: 'array' })
    const blob = new Blob([excelBuffer], { type: 'application/octet-stream' })
    const downloadUrl = window.URL.createObjectURL(blob)
    const link = document.createElement('a')
    link.href = downloadUrl
    link.setAttribute('download', 'Export.xlsx')
    document.body.appendChild(link)
    link.click()
    document.body.removeChild(link)
  }

  return (
    <div className='section flex flex-col lg:mx-20 mx-2'>
      {/*  */}
      <div className='flex flex-col items-center text-base my-4 mt-[0px]'>
        <label htmlFor='dateTo'>Selected OPEL machine:</label>
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
      <div className='flex flex-col lg:flex-row lg:space-x-8 -lg:space-y-4 border-l-4 border-collor1 pb-4 gap-y-2'>
        <div className='flex flex-row px-2 gap-x-2'>
          {/* DATE from */}
          <div className='text-base flex flex-col items-center'>
            <label htmlFor='dateFrom'>Date from:</label>
            <input
              type='datetime-local'
              onChange={handleDateFromChange}
              className='rounded-sm text-collor1 px-1 cursor-pointer hover:ring-4 ring-collor1'
            />
          </div>
          {/* DATE to  */}
          <div className='text-base flex flex-col items-center'>
            <label htmlFor='dateTo'>Date to:</label>
            <input
              type='datetime-local'
              onChange={handleDateToChange}
              className='rounded-sm text-collor1 px-1 cursor-pointer hover:ring-4 ring-collor1'
            />
          </div>
        </div>
        <div className='flex px-2 mx-auto '>
          {/* TEMP from */}
          <div className='text-base flex flex-col items-center w-[6.25rem]'>
            <label htmlFor='dateFrom'>Temp from:</label>
            <input
              placeholder='0.0'
              type='number'
              onChange={handleWaterTempFromChange}
              className='rounded-sm text-collor1 px-1 cursor-pointer w-[80px] hover:ring-4 ring-collor1'
            />
          </div>
          {/* TEMP to  */}
          <div className='text-base flex flex-col items-center w-[6.25rem]'>
            <label htmlFor='dateTo'>Temp to:</label>
            <input
              placeholder='100.0'
              type='number'
              onChange={handleWaterTempToChange}
              className='rounded-sm text-collor1 px-1 cursor-pointer w-[80px] hover:ring-4 ring-collor1'
            />
          </div>
        </div>
        {/*  */}
        {/* items on page  */}
        <div className='text-base flex flex-col items-center'>
          <label htmlFor='records'>Items on page:</label>
          <input
            value={pageSize}
            type='number'
            id='itemspage'
            className='mx-2 align-middle rounded-md text-collor1 cursor-pointer px-2 w-[80px] hover:ring-4 ring-collor1'
            onChange={(e) => setPageSize(parseInt(e.target.value))}
          />
        </div>

        {/* descending */}
        <div className='flex mx-auto justify-between space-x-7 max-lg:mt-6'>
          <div className='text-base flex flex-col items-center text-center'>
            <label htmlFor='isDescending'>Is Descending:</label>
            <input
              type='checkbox'
              id='isDescending'
              defaultChecked={true}
              className='mx-2 align-middle size-5 rounded-md text-collor1 cursor-pointer hover:ring-4 ring-collor1'
              onChange={handleIsDescendingChange}
            />
          </div>
          {/* show records  */}
          <div className='text-base flex flex-col items-center'>
            <label htmlFor='records'>Records:</label>
            <h2 className='text-collor2 pr-2 h2 text-2xl'>{totalRecords}</h2>
          </div>
          {/* EXPORT data  */}
          <button onClick={handleExport} className='btn btn-sm m-0 group'>
            <div className='centerBtn uppercase relative w-[100%] flex justify-between md:w-[85%]'>
              <span className='md:text-xl text-base group-hover:mt-[-100px] group-hover:absolute duration-500'>Export data</span>
              <span className='md:text-xl text-base mb-[-100px] group-hover:mb-[-4px] group-hover:relative  absolute duration-500'>
                Download
              </span>
              <PiExportLight size={35} className='absolute right-0' />
            </div>
          </button>
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
        {opelData.length === 0 ? (
          <h2 className='mx-auto text-center'>No Data</h2>
        ) : (
          <div className='space-y-5'>
            {opelData.map((item) => (
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
                  <span className='text-primary '> Water temp. Left :</span> {item.waterTempLeft}&deg;C
                  <span className='text-collor1'> | </span>
                </p>
                <p>
                  <span className='text-primary '> Water temp. Right :</span> {item.waterTempRight}&deg;C
                  <span className='text-collor1'> | </span>
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
          className={`${opelData.length < pageSize ? 'invisible' : 'block'} btn_2 px-2 w-[100px]`}
        >
          Next Page
        </button>
      </div>
    </div>
  )
}

export default Db_opelMachines
