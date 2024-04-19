import { useState, useEffect } from 'react'
import axios from 'axios'
import loadConfig from '../../../loadConfig'
const config = loadConfig()

const Db_asqMachines = () => {
  // URL
  const [asqMachine, setAsqMachine] = useState(null)
  const url = `http://${config.apiBaseUrl}:5147/api/db/${asqMachine}`
  //
  // DATA
  const [asqData, setAsqData] = useState([]) // data from eqc
  const [totalRecords, setTotalRecords] = useState(0) //total records
  //  SORT
  const [dateFrom, setDateFrom] = useState('') // from date
  const [dateTo, setDateTo] = useState('') // to date
  const [isDescending, setIsDescending] = useState(true) // descending ascending
  const [toolNum, setToolNum] = useState('') // filter tool number
  // A or B
  const [selected_A, setSelected_A] = useState(false)
  const [selected_B, setSelected_B] = useState(false)
  // Global
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
          SelectAsq_A: selected_A,
          SelectAsq_B: selected_B,
          ToolNum: toolNum,
          PageNumber: pageNumber,
          PageSize: pageSize,
        },
      })
      var data = await response.data
      setAsqData(data.asqdb)
      setTotalRecords(data.totalRecords)
      setLoadingData(false)
      console.log(data)
    } catch (error) {
      setLoadingData(false)
      console.log(error.response)
    }
  }

  useEffect(() => {
    if (asqMachine === '' || asqMachine === null) {
      setAsqData([])
      setTotalRecords(0)
      setLoadingData(false)
    } else {
      fetchData()
    }
  }, [isDescending, toolNum, pageNumber, pageSize, dateFrom, dateTo, asqMachine, selected_A, selected_B]) // Aktualizácia dát pri zmene filtrov

  useEffect(() => {
    window.scrollTo({ top: 0, behavior: 'smooth' })
    if (asqData.length === 0) {
      setPageNumber(1)
    }
  }, [pageNumber, asqData, dateTo, dateFrom, isDescending, toolNum])

  //
  //
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

  const handleRobotChange = (event) => {
    const selectedRobot = event.target.value
    if (selectedRobot === 'A') {
      setSelected_A(true)
      setSelected_B(false)
    }
    if (selectedRobot === 'B') {
      setSelected_B(true)
      setSelected_A(false)
    }
    if (selectedRobot === 'ALL') {
      setSelected_A(false)
      setSelected_B(false)
    }
    setPageNumber(1)
  }

  const handleMachineChoose = (event) => {
    const machine = event.target.value
    setAsqMachine(machine)
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
    { value: '21', label: 'Tool_21' },
    { value: '22', label: 'Tool_22' },
    { value: '23', label: 'Tool_23' },
    { value: '24', label: 'Tool_24' },
    { value: '25', label: 'Tool_25' },
    { value: '26', label: 'Tool_26' },
    { value: '27', label: 'Tool_27' },
    { value: '28', label: 'Tool_28' },
    { value: '29', label: 'Tool_29' },
    { value: '30', label: 'Tool_30' },
  ]

  const machines = [
    { value: '', label: 'Choose machine' },
    { value: 'asq2', label: 'ASQ_2' },
    { value: 'asq3', label: 'ASQ_3' },
    { value: 'asq4', label: 'ASQ_4' },
    { value: 'asq5', label: 'ASQ_5' },
    { value: 'asq6', label: 'ASQ_6' },
  ]

  return (
    <div className='section flex flex-col lg:mx-20 mx-2'>
      {/*  */}
      <div className='flex flex-col items-center text-base my-4 mt-[0px]'>
        <label htmlFor='dateTo'>Selected ASQ machine:</label>
        <select
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

        {/* Choose robot && select TOOL  */}
        <div className='flex px-2 mx-auto'>
          <div className='flex flex-col items-center text-base'>
            <label htmlFor='dateTo'>Selected Robot:</label>
            <select onChange={handleRobotChange} className='text-xl mr-2  px-8 rounded-sm text-collor1 cursor-pointer'>
              <option value={'ALL'} className=''>
                Robot A&B
              </option>
              <option value={'A'} className=''>
                Robot A
              </option>
              <option value={'B'} className=''>
                Robot B
              </option>
            </select>
          </div>
          {/* select tool  */}
          <div className='flex flex-col items-center text-base'>
            <label htmlFor='dateTo'>Selected Tool:</label>
            <select
              disabled={!selected_A && !selected_B}
              name={toolNum}
              onChange={handleToolNumChange}
              className='text-xl px-10 rounded-sm text-collor1 cursor-pointer'
            >
              {tools.map((option) => (
                <option key={option.value} value={option.value} className=''>
                  {option.label}
                </option>
              ))}
            </select>
          </div>
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
        {asqData.length === 0 ? (
          <h2 className='mx-auto text-center'>No Data</h2>
        ) : (
          <div className='space-y-5'>
            {asqData.map((item) => (
              <div key={item.id} className='flex flex-wrap border border-primary/20 rounded-lg p-2'>
                <h2 className={`${item.product_A ? 'bg-blue-400' : 'bg-orange-400'} text-black font-bold px-2 rounded-md mr-2`}>
                  {item.product_A ? 'ROBOT_A PRODUCT' : 'ROBOT_B PRODUCT'}
                </h2>
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
                  <span className='text-primary '> Go Weight after:</span> {item.global_GoWeightAfter}
                  <span className='text-collor1'> | </span>
                </p>
                <p>
                  <span className='text-primary '> Mixing time:</span> {item.global_MixingTime}s
                  <span className='text-collor1'> | </span>
                </p>
                <p>
                  <span className='text-primary '> Ref. value:</span> {item.global_RefValue}g
                  <span className='text-collor1'> | </span>
                </p>
                <p>
                  <span className='text-primary '>Weight Tol. minimum:</span> {item.global_WeightTolMinus}g
                  <span className='text-collor1'> | </span>
                </p>
                <p>
                  <span className='text-primary '> Weight Tol. maximum:</span> {item.global_WeightTolPlus}g
                  <span className='text-collor1'> | </span>
                </p>
                {/*IF ROBOT A SHOT  */}
                {item.product_A && (
                  <>
                    <p>
                      <span className='text-primary '> Robot A Cycle time:</span> {item.roB1_CycleTime}s
                      <span className='text-collor1'> | </span>
                    </p>
                    <p>
                      <span className='text-primary '> Form Number:</span> {item.roB1_FormNumber}
                      <span className='text-collor1'> | </span>
                    </p>
                    <p>
                      <span className='text-primary '> Set temperature:</span> {item.roB1_SetTemperature}
                      <span className='text-collor1'> | </span>
                    </p>
                    <p>
                      <span className='text-primary '> Temperature:</span> {item.roB1_Temperature}
                      <span className='text-collor1'> | </span>
                    </p>
                    <p>
                      <span className='text-primary '> Actual Weight:</span> {item.roB1_WeightActualValue}g
                      <span className='text-collor1'> | </span>
                    </p>
                    <p>
                      <span className='text-primary '> Time drying:</span> {item.roB1_TimeDrying}
                      <span className='text-collor1'> | </span>
                    </p>
                  </>
                )}
                {/*  */}
                {/*IF ROBOT B SHOT  */}
                {item.product_B && (
                  <>
                    <p>
                      <span className='text-primary '> Robot B Cycle time:</span> {item.roB2_CycleTime}s
                      <span className='text-collor1'> | </span>
                    </p>
                    <p>
                      <span className='text-primary '> Form Number:</span> {item.roB2_FormNumber}
                      <span className='text-collor1'> | </span>
                    </p>
                    <p>
                      <span className='text-primary '> Set temperature:</span> {item.roB2_SetTemperature}
                      <span className='text-collor1'> | </span>
                    </p>
                    <p>
                      <span className='text-primary '> Temperature:</span> {item.roB2_Temperature}
                      <span className='text-collor1'> | </span>
                    </p>
                    <p>
                      <span className='text-primary '> Actual Weight:</span> {item.roB2_WeightActualValue}g
                      <span className='text-collor1'> | </span>
                    </p>
                    <p>
                      <span className='text-primary '> Time drying:</span> {item.roB2_TimeDrying}
                      <span className='text-collor1'> | </span>
                    </p>
                  </>
                )}
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
          className={`${asqData.length < pageSize ? 'invisible' : 'block'} btn_2 px-2 w-[100px]`}
        >
          Next Page
        </button>
      </div>
    </div>
  )
}
export default Db_asqMachines
