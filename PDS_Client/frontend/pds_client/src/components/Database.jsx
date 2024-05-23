import { Link } from 'react-router-dom'

const Database = () => {
  return (
    <>
      <div className='section mx-6 lg:mx-32'>
        <div className='flex flex-col lg:flex-row gap-x-28 gap-y-9 w-full mx-auto justify-center'>
          <div className='flex flex-col lg:flex-row flex-wrap lg:gap-x-10 gap-y-9 w-full items-center justify-center'>
            <Link
              to='/database/dbeqcmachines'
              className='w-full lg:min-w-[500px] max-w-[650px] h-[18.75rem] lg:h-[700px] rounded-2xl shadow-lg shadow-black uppercase p-5 hover:shadow-collor1 drop-shadow-sm transition-all duration-200 hover:ring-4 ring-inset bg-secondary/60 overflow-hidden'
            >
              <div className='flex flex-col group justify-between h-full'>
                <h1 className='h2 text-primary relative'>Eqc middlefield database</h1>
                <img
                  src='/machinePicture/eqcMachine.png'
                  alt='dashboard'
                  className='size-[600px]  mix-blend-overlay group-hover:mix-blend-hard-light'
                />
              </div>
            </Link>
            <Link
              to='/database/dbasqmachines'
              className='w-full lg:min-w-[500px] max-w-[650px] h-[18.75rem] lg:h-[700px] rounded-2xl shadow-lg shadow-black uppercase p-5 hover:shadow-collor1 drop-shadow-sm transition-all duration-200 hover:ring-4 ring-inset bg-collor1/60 overflow-hidden'
            >
              <div className='flex flex-col group justify-between h-full'>
                <h1 className=' h2 text-white relative'>
                  Asq <br /> database
                </h1>
                <img
                  src='/machinePicture/asqMachine.png'
                  alt='dashboard'
                  className=' size-[600px]  mix-blend-overlay group-hover:mix-blend-hard-light '
                />
              </div>
            </Link>
            <Link
              to='/database/dbopelmachines'
              className='w-full lg:min-w-[500px] max-w-[650px] h-[18.75rem] lg:h-[700px] rounded-2xl shadow-lg shadow-black uppercase p-5 hover:shadow-collor1 drop-shadow-sm transition-all duration-200 hover:ring-4 ring-inset bg-collor2/60 overflow-hidden'
            >
              <div className='flex flex-col group justify-between h-full'>
                <h1 className='h2 text-primary relative'>Opel armrest/insert database</h1>
                <img
                  src='/machinePicture/armrestMachine.png'
                  alt='dashboard'
                  className='size-[600px]  mix-blend-overlay group-hover:mix-blend-hard-light'
                />
              </div>
            </Link>
          </div>
        </div>
      </div>
    </>
  )
}
export default Database
